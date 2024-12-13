# 0-based counting - 0,1,2,3,4
# 1-based counting - 1,2,3,4,5

# first_names = [None] * 5

# first_names[0] = "Tim"
# first_names[1] = "Sue"
# first_names[2] = "Bob"
# first_names[4] = "Jane"

# print(f"The first names are {first_names[0]}, {first_names[1]}, {first_names[2]}, {first_names[4]}")

# first_names[0] = "Timothy"

# print(first_names[0])

# first_names[5] = "Robert"

# single quote identifies a char
# double quotes identifies a string
data = "Tim,Sue,Bob,Jane,Frank"
first_names = data.split(',')

print(first_names[-1])

print(len(first_names))

last_names = ["Corey", "Smith", "Jones"]

ages = [2, 3, 4]
