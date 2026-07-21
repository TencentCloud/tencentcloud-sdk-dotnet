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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AclRegInfo : AbstractModel
    {
        
        /// <summary>
        /// 地域KEY
        /// </summary>
        [JsonProperty("RegionCode")]
        public string RegionCode{ get; set; }

        /// <summary>
        /// 地域名称
        /// </summary>
        [JsonProperty("RegionName")]
        public string RegionName{ get; set; }

        /// <summary>
        /// 上级地域信息
        /// </summary>
        [JsonProperty("Parent")]
        public string Parent{ get; set; }

        /// <summary>
        /// 中文拼音首字母
        /// </summary>
        [JsonProperty("ZhKey")]
        public string ZhKey{ get; set; }

        /// <summary>
        /// 英文首字母
        /// </summary>
        [JsonProperty("EnKey")]
        public string EnKey{ get; set; }

        /// <summary>
        /// 是否为地区
        /// </summary>
        [JsonProperty("Area")]
        public long? Area{ get; set; }

        /// <summary>
        /// 是否为省份、城市
        /// </summary>
        [JsonProperty("IsCity")]
        public long? IsCity{ get; set; }

        /// <summary>
        /// 序号
        /// </summary>
        [JsonProperty("Num")]
        public long? Num{ get; set; }

        /// <summary>
        /// 是否支持旁路
        /// </summary>
        [JsonProperty("ForBypass")]
        public long? ForBypass{ get; set; }

        /// <summary>
        /// 是否支持串行
        /// </summary>
        [JsonProperty("ForSerial")]
        public long? ForSerial{ get; set; }

        /// <summary>
        /// 是否支持NAT
        /// </summary>
        [JsonProperty("ForNat")]
        public long? ForNat{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RegionCode", this.RegionCode);
            this.SetParamSimple(map, prefix + "RegionName", this.RegionName);
            this.SetParamSimple(map, prefix + "Parent", this.Parent);
            this.SetParamSimple(map, prefix + "ZhKey", this.ZhKey);
            this.SetParamSimple(map, prefix + "EnKey", this.EnKey);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "IsCity", this.IsCity);
            this.SetParamSimple(map, prefix + "Num", this.Num);
            this.SetParamSimple(map, prefix + "ForBypass", this.ForBypass);
            this.SetParamSimple(map, prefix + "ForSerial", this.ForSerial);
            this.SetParamSimple(map, prefix + "ForNat", this.ForNat);
        }
    }
}

