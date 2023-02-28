import sys
import os
import ctypes
import time
import argparse


def stitch_images(states, active, inactive, output_filename="output.ico"):
    # based on the active states, stick Active_B.png and Active_W.png together in a 2x2 grid using imagemagick
    
    grid_images = []
    
    for i, state in enumerate(states):
        if state:
            grid_images.append(active)
        else:
            grid_images.append(inactive)
            
    # stitch the images together in a 2x2 grid, keeping transparency    
    command = f"montage -define icon:auto-resize -geometry 48x48+2+2 -tile 2x2 -background none {' '.join(grid_images)} temp"
    os.system(command)
    name = output_filename.replace(".ico", "_B.ico")
    command = f"convert temp -define icon:auto-resize=64,48,32,16 {name}"
    os.system(command)
    name = output_filename.replace(".ico", "_W.ico")
    command = f"convert temp -define icon:auto-resize=64,48,32,16 -channel RGB -negate {name}"
    os.system(command)


def braille_encode(states):
    output = ""
    braille = ["⠀", "⠁", "⠈", "⠂", "⠐", "⠉", "⠒","⠃", "⠘", "⠑", "⠊", "⠋", "⠓", "⠚", "⠙", "⠛"]
    
    # states is just an array of booleans
    
    # use switch statement to determine which braille character to use
    if states == [False, False, False, False]:
        output = braille[0]
    elif states == [True, False, False, False]:
        output = braille[1]
    elif states == [False, True, False, False]:
        output = braille[2]
    elif states == [False, False, True, False]:
        output = braille[3]
    elif states == [False, False, False, True]:
        output = braille[4]
    elif states == [True, True, False, False]:
        output = braille[5]
    elif states == [False, False, True, True]:
        output = braille[6]
    elif states == [True, False, True, False]:
        output = braille[7]
    elif states == [False, True, False, True]:
        output = braille[8]
    elif states == [True, False, False, True]:
        output = braille[9]
    elif states == [False, True, True, False]:
        output = braille[10]
    elif states == [True, True, True, False]:
        output = braille[11]
    elif states == [True, False, True, True]:
        output = braille[12]
    elif states == [False, True, True, True]:
        output = braille[13]
    elif states == [True, True, False, True]:
        output = braille[14]
    elif states == [True, True, True, True]:
        output = braille[15]
        
    return output
      



def check_key_states():
    if sys.platform == "win32":
        states = {
            "caps": False,
            "num": False,
            "insert": False,
            "scroll": False
        }
        
        # check if caps lock is enabled
        if ctypes.windll.user32.GetKeyState(0x14):
            # add Caps Lock and a tick to the output
            states["caps"] = True
        # check if num lock is enabled
        if ctypes.windll.user32.GetKeyState(0x90):
            states["num"] = True
        # check if insert is enabled
        if ctypes.windll.user32.GetKeyState(0x2D):
            states["insert"] = True
        # check if scroll lock is enabled
        if ctypes.windll.user32.GetKeyState(0x91):
            states["scroll"] = True
            
        # print(states)        
        # print braille based on which states are true, with top left being caps lock, top right being num lock, bottom left being insert, and bottom right being scroll lock
        # print("<" + braille_encode([states["caps"], states["num"], states["insert"], states["scroll"]]) + ">")
        
        return states
            

def generate_images(active, inactive):
    print("Generating images...")
    
    # use stitch_images to stitch every possible combination of states together
    # if the true states are [caps, num, insert, scroll], then the output filename should be "Active_CNIS.png", where C is for caps, N is for num, I is for insert, and S is for scroll
    # if the true statee is [caps, num, insert], then the output filename should be "Active_CNI.png", etc
    
    # create states folder if it doesn't exist
    if not os.path.exists("states"):
        os.makedirs("states")
    
    for i in range(16):
        states = [False, False, False, False]
        
        if i & 1:
            states[0] = True
        if i & 2:
            states[1] = True
        if i & 4:
            states[2] = True
        if i & 8:
            states[3] = True
            
        state_string = ''.join(['C' if states[0] else '', 'N' if states[1] else '', 'I' if states[2] else '', 'S' if states[3] else ''])
        file_name = f"states/Active_{state_string}.ico" if state_string else "states/Active_None.ico"
            
        print(f"  Generating {file_name.split('/')[1].replace('.ico', '')}")
            
        stitch_images(states, active, inactive, file_name)
        
    # delete temp file
    os.remove("temp")
    
    print("Done!")


def key_state_string(states):
    string = ""
    
    for state in states:
        name = state
        value = states[state]

        # if the state is true and the key is caps, num, insert, or scroll, add the corresponding letter to the string
        if value:
            if name == "caps":
                string += "C" 
            elif name == "num":
                string += "N"
            elif name == "insert":
                string += "I"
            elif name == "scroll":
                string += "S"
                
    string = string if string else "None"
                
    return string


if __name__ == "__main__":
    # generate args
    parser = argparse.ArgumentParser(description="Various key state utilities")
    parser.add_argument("-g", "--generate", action="store_true", help="Generate all possible key state images")
    parser.add_argument("-ia", "--image_source_active", help="The source image to use for active keys")
    parser.add_argument("-in", "--image_source_inactive", help="The source image to use for inactive keys")
    args = parser.parse_args()
    
    if len(sys.argv) == 1:
        args.generate = True
    
    
    # if the generate flag is set, generate all possible key state images
    if args.generate:
        
        active = args.image_source_active if args.image_source_active else input("Enter the path to the source image to use for active keys: ")
        inactive = args.image_source_inactive if args.image_source_inactive else input("Enter the path to the source image to use for inactive keys: ")
        
        generate_images(active, inactive)
    
    
    
    