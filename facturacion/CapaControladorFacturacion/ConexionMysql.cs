using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;

namespace CapaControladorFacturacion {
    class ConexionMysql {

        private string nombreConexion;
        private OdbcConnection nuevaConexion;
        public ConexionMysql( string nombreConexion ) {
            this.nombreConexion = nombreConexion;
        }
        public OdbcConnection Conectar() {
           
            nuevaConexion = new OdbcConnection( "Dsn = " + nombreConexion );

            try {

                nuevaConexion.Open();

            } catch ( OdbcException ex ) {

                MessageBox.Show( ex.Message );
            }

            return nuevaConexion;
        }
        public void Desconectar()
        {

            try {

                nuevaConexion.Close();

            } catch( OdbcException ex ) {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
