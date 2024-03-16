import logo from './baybowlerlogo.png';

function Header(props: any) {
  return (
    <header className="row navbar navbar-dark bg-dark">
      <div className="col-4">
        <img src={logo} alt="baybowlerlogo" />
      </div>
      <div className="col subtitle">
        <h1 className="text-white">{props.title}</h1>
        <p className="text-white">Join us on Wednesday Nights!</p>
      </div>
    </header>
  );
}

export default Header;
