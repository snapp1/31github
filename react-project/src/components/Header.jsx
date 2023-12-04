import img from "../assets/react-core-concepts.png"

export function Header(){
    return(
      <header>
        <img src={img} alt="Stylized atom" />
        <h1>React Essentials</h1>
        <p>
          React concepts you will need for almost any app you are
          going to build!
        </p>
      </header>
    );
  }