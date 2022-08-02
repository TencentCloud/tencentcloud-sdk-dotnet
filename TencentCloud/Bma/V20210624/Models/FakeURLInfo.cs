/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
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

namespace TencentCloud.Bma.V20210624.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FakeURLInfo : AbstractModel
    {
        
        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLId")]
        public long? FakeURLId{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("ProtectWeb")]
        public string ProtectWeb{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("DetectTime")]
        public string DetectTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURL")]
        public string FakeURL{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Snapshot")]
        public string Snapshot{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("IP")]
        public string IP{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("IPLoc")]
        public string IPLoc{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Heat")]
        public long? Heat{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("Note")]
        public string Note{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLCompany")]
        public string FakeURLCompany{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLAttr")]
        public string FakeURLAttr{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLName")]
        public string FakeURLName{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLICP")]
        public string FakeURLICP{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLCreateTime")]
        public string FakeURLCreateTime{ get; set; }

        /// <summary>
        /// xxx
        /// </summary>
        [JsonProperty("FakeURLExpireTime")]
        public string FakeURLExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FakeURLId", this.FakeURLId);
            this.SetParamSimple(map, prefix + "ProtectWeb", this.ProtectWeb);
            this.SetParamSimple(map, prefix + "DetectTime", this.DetectTime);
            this.SetParamSimple(map, prefix + "FakeURL", this.FakeURL);
            this.SetParamSimple(map, prefix + "Snapshot", this.Snapshot);
            this.SetParamSimple(map, prefix + "IP", this.IP);
            this.SetParamSimple(map, prefix + "IPLoc", this.IPLoc);
            this.SetParamSimple(map, prefix + "Heat", this.Heat);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "Note", this.Note);
            this.SetParamSimple(map, prefix + "FakeURLCompany", this.FakeURLCompany);
            this.SetParamSimple(map, prefix + "FakeURLAttr", this.FakeURLAttr);
            this.SetParamSimple(map, prefix + "FakeURLName", this.FakeURLName);
            this.SetParamSimple(map, prefix + "FakeURLICP", this.FakeURLICP);
            this.SetParamSimple(map, prefix + "FakeURLCreateTime", this.FakeURLCreateTime);
            this.SetParamSimple(map, prefix + "FakeURLExpireTime", this.FakeURLExpireTime);
        }
    }
}

