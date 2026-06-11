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

    public class ExpandCfwVerticalRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>nat：nat防火墙，ew：东西向防火墙</p>
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// <p>带宽值</p>
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// <p>防火墙实例id</p>
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// <p>弹性开关 1打开 0 关闭</p>
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public long? ElasticSwitch{ get; set; }

        /// <summary>
        /// <p>弹性带宽上限，单位Mbps</p>
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public long? ElasticBandwidth{ get; set; }

        /// <summary>
        /// <p>按量计费标签</p>
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }

        /// <summary>
        /// <p>按流量弹性开关</p><p>取值范围：[0, 1]</p><p>默认值：0</p>
        /// </summary>
        [JsonProperty("ElasticTrafficSwitch")]
        public long? ElasticTrafficSwitch{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "FwType", this.FwType);
            this.SetParamSimple(map, prefix + "Width", this.Width);
            this.SetParamSimple(map, prefix + "CfwInstance", this.CfwInstance);
            this.SetParamSimple(map, prefix + "ElasticSwitch", this.ElasticSwitch);
            this.SetParamSimple(map, prefix + "ElasticBandwidth", this.ElasticBandwidth);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "ElasticTrafficSwitch", this.ElasticTrafficSwitch);
        }
    }
}

