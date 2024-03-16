import { useEffect, useState } from 'react';
import { BowlingLeague } from '../types/BowlingLeague';

function BowlerList() {
  const [bowlerData, setBowlerData] = useState<BowlingLeague[]>([]);

  useEffect(() => {
    const fetchBowlerData = async () => {
      const rsp = await fetch('http://localhost:5244/api/Bowling');
      const b = await rsp.json();
      setBowlerData(b);
    };
    fetchBowlerData();
  }, []);

  return (
    <>
      <div className="row">
        <h4 className="text-center">Baylor's Bowlers' Statistics</h4>
      </div>
      <table className="table table-bordered">
        <thead>
          <tr>
            <th>Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip Code</th>
            <th>Phone Number</th>
            <th>Team</th>
          </tr>
        </thead>
        <tbody>
          {bowlerData.map((b) => (
            <tr key={b.bowlerID}>
              <td>{`${b.bowlerFirstName} ${b.bowlerMiddleInit ? b.bowlerMiddleInit + '. ' : ''}${b.bowlerLastName}`}</td>
              <td>{b.bowlerAddress}</td>
              <td>{b.bowlerCity}</td>
              <td>{b.bowlerState}</td>
              <td>{b.bowlerZip}</td>
              <td>{b.bowlerPhoneNumber}</td>
              <td>{b.teamName}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </>
  );
}

export default BowlerList;
