using System.Net;
using FaithVentures.Sets;

namespace FaithVentures {
    public class FaithVenturesClient {
        private readonly FaithVenturesOptions _options;
        private ExpeditionSet _expeditionSet;
        private PolicySet _policySet;

        public FaithVenturesClient(FaithVenturesOptions options) {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
            _options = options;
        }

        public ExpeditionSet Expeditions {
            get {
                if (_expeditionSet == null) {
                    _expeditionSet = new ExpeditionSet(_options);
                }

                return _expeditionSet;
            }
        }

        public PolicySet Policies {
            get {
                if (_policySet == null) {
                    _policySet = new PolicySet(_options);
                }

                return _policySet;
            }
        }
    }
}
