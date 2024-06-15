namespace StructsAndAlgsTests
{
    public class StackTests
    {
        [Fact]
        public void AddItemsToStack()
        {
            var stack = new StructsAndAlgs.Stack.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.Count);
            Assert.Equal(3, stack.GetTop());
        }

        [Fact]
        public void PopItemsFromStack()
        {
            var stack = new StructsAndAlgs.Stack.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.Count);
            Assert.Equal(3, stack.GetTop());

            stack.Pop();
            Assert.Equal(2, stack.Count);
            Assert.Equal(2, stack.GetTop());

            stack.Pop();
            Assert.Equal(1, stack.Count);
            Assert.Equal(1, stack.GetTop());

            stack.Pop();
            Assert.Equal(0, stack.Count);
            Assert.Throws<NullReferenceException>(() => stack.GetTop());
        }

        [Fact]
        public void EmptyThrows()
        {
            var stack = new StructsAndAlgs.Stack.Stack<int>();
            Assert.Throws<NullReferenceException>(() => stack.GetTop());
        }

        [Fact]
        public void ClearStack()
        {
            var stack = new StructsAndAlgs.Stack.Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Assert.Equal(3, stack.Count);
            Assert.Equal(3, stack.GetTop());
            stack.Clear();
            Assert.Equal(0, stack.Count);
            Assert.Throws<NullReferenceException>(() => stack.GetTop());
        }
    }
}