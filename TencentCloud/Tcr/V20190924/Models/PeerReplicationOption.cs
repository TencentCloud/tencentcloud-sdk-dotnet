/*
 * Copyright (c) 2018-2025 Tencent. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Tcr.V20190924.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class PeerReplicationOption : AbstractModel
    {
        
        /// <summary>
        /// 待同步实例的uin
        /// </summary>
        [JsonProperty("PeerRegistryUin")]
        public string PeerRegistryUin{ get; set; }

        /// <summary>
        /// 待同步实例的访问永久Token
        /// </summary>
        [JsonProperty("PeerRegistryToken")]
        public string PeerRegistryToken{ get; set; }

        /// <summary>
        /// 是否开启跨主账号实例同步
        /// </summary>
        [JsonProperty("EnablePeerReplication")]
        public bool? EnablePeerReplication{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "PeerRegistryUin", this.PeerRegistryUin);
            this.SetParamSimple(map, prefix + "PeerRegistryToken", this.PeerRegistryToken);
            this.SetParamSimple(map, prefix + "EnablePeerReplication", this.EnablePeerReplication);
        }
    }
}

