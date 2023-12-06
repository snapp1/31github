import {CORE_CONCEPTS} from "./data.js"
import {Header} from "./components/Header.jsx"
import {CoreConcept} from "./components/CoreConcept.jsx"
import TabButton from "./components/TabButton.jsx"
import { useState } from "react";
import { EXAMPLES } from "./data.js";

function App() {
  const [val, setVal] = useState("jsx");

  function clickHandler(type){
    setVal(type)
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
            <TabButton clickHandler={() => clickHandler("components")}>Components</TabButton>
            <TabButton clickHandler={() => clickHandler("jsx")}>JSX</TabButton>
            <TabButton clickHandler={() => clickHandler("props")}>Props</TabButton>
            <TabButton clickHandler={() => clickHandler("state")}>State</TabButton>
          </menu>
          <div id="tab-content">
            <h3>{EXAMPLES[val].title}</h3>
            <p>{EXAMPLES[val].description}</p>
            <pre>
              <code>
                {EXAMPLES[val].code}
              </code>
            </pre>
          </div>
        </section>
      </main>
    </div>
  );
}

export default App;
