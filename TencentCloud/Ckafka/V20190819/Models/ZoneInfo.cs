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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ZoneInfo : AbstractModel
    {
        
        /// <summary>
        /// zone的id
        /// </summary>
        [JsonProperty("ZoneId")]
        public string ZoneId{ get; set; }

        /// <summary>
        /// 是否内部APP
        /// </summary>
        [JsonProperty("IsInternalApp")]
        public long? IsInternalApp{ get; set; }

        /// <summary>
        /// app id
        /// </summary>
        [JsonProperty("AppId")]
        public long? AppId{ get; set; }

        /// <summary>
        /// 标识
        /// </summary>
        [JsonProperty("Flag")]
        public bool? Flag{ get; set; }

        /// <summary>
        /// zone名称
        /// </summary>
        [JsonProperty("ZoneName")]
        public string ZoneName{ get; set; }

        /// <summary>
        /// zone状态
        /// </summary>
        [JsonProperty("ZoneStatus")]
        public long? ZoneStatus{ get; set; }

        /// <summary>
        /// 额外标识
        /// </summary>
        [JsonProperty("Exflag")]
        public string Exflag{ get; set; }

        /// <summary>
        /// json对象，key为机型，value true为售罄，false为未售罄
        /// </summary>
        [JsonProperty("SoldOut")]
        public string SoldOut{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ZoneId", this.ZoneId);
            this.SetParamSimple(map, prefix + "IsInternalApp", this.IsInternalApp);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "ZoneName", this.ZoneName);
            this.SetParamSimple(map, prefix + "ZoneStatus", this.ZoneStatus);
            this.SetParamSimple(map, prefix + "Exflag", this.Exflag);
            this.SetParamSimple(map, prefix + "SoldOut", this.SoldOut);
        }
    }
}

