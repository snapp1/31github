import {CORE_CONCEPTS} from "./data.js"
import {Header} from "./components/Header.jsx"
import {CoreConcept} from "./components/CoreConcept.jsx"
import TabButton from "./components/TabButton.jsx"
import { useState } from "react";

function App() {
  const [val, setVal] = useState("Initial val");

  function clickHandler(type){
    if(type === 0){
      setVal("Hoh!")
    }else if(type === 1){
      setVal("Hah!")
    }else if(type === 2){
      setVal("Heh!")
    }else if(type === 3){
      setVal("Hyh!")
    }
  }
  return (
    <div>
    <Header />
      <main>
        <section id="core-concepts">
          <h2>Time to get started!</h2>
          <ul>
            <CoreConcept {...CORE_CONCEPTS[0]}/>
            <CoreConcept {...CORE_CONCEPTS[1]}/>
            <CoreConcept {...CORE_CONCEPTS[2]}/>
            <CoreConcept {...CORE_CONCEPTS[3]}/>
          </ul>
        </section>
        <section id="examples">
          <h2>Examples!</h2>
          <menu>
            <TabButton clickHandler={() => clickHandler(0)}>Components</TabButton>
            <TabButton clickHandler={() => clickHandler(1)}>JSX</TabButton>
            <TabButton clickHandler={() => clickHandler(2)}>Props</TabButton>
            <TabButton clickHandler={() => clickHandler(3)}>State</TabButton>
          </menu>
          {val}
        </section>
      </main>
    </div>
  );
}

export default App;
