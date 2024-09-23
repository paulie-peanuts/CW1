class MessageBuilder:
    def __init__(self, initial_word):
        self.words = [initial_word]

    def __call__(self, next_word=None):
        if next_word is None:
            return " ".join(self.words)
        self.words.append(next_word)
        return self
def create_message(initial_word):
    return MessageBuilder(initial_word)

# Implement a function that receives a string, and lets you extend it with repeated calls. When no argument is passed you should return a string consisting of space-separated words you've received earlier.

# Note: There will always be at least 1 string; all inputs will be non-empty.

# For example:

# create_message("Hello")("World!")("how")("are")("you?")() == "Hello World! how are you?"