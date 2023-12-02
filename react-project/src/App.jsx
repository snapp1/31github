import img from "./assets/react-core-concepts.png"

const arr = ['A', 'B', 'C'];

function rndInt(max){
  return Math.floor(Math.random() * (max+1));
}

function Header(){
  return(
    <header>
      <img src={img} alt="Stylized atom" />
      <h1>React Essentials</h1>
      <p>
        {arr[rndInt(2)]} React concepts you will need for almost any app you are
        going to build!
      </p>
    </header>
  );
}

function App() {
  return (
    <div>
    <Header />
      <main>
        <h2>Time to get started!</h2>
      </main>
    </div>
  );
}

export default App;
