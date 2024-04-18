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

namespace TencentCloud.Cfw.V20190904.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ExpandCfwVerticalRequest : AbstractModel
    {
        
        /// <summary>
        /// nat：nat防火墙，ew：东西向防火墙
        /// </summary>
        [JsonProperty("FwType")]
        public string FwType{ get; set; }

        /// <summary>
        /// 带宽值
        /// </summary>
        [JsonProperty("Width")]
        public ulong? Width{ get; set; }

        /// <summary>
        /// 防火墙实例id
        /// </summary>
        [JsonProperty("CfwInstance")]
        public string CfwInstance{ get; set; }

        /// <summary>
        /// 弹性开关 1打开 0 关闭
        /// </summary>
        [JsonProperty("ElasticSwitch")]
        public long? ElasticSwitch{ get; set; }

        /// <summary>
        /// 弹性带宽上限，单位Mbps
        /// </summary>
        [JsonProperty("ElasticBandwidth")]
        public long? ElasticBandwidth{ get; set; }

        /// <summary>
        /// 按量计费标签
        /// </summary>
        [JsonProperty("Tags")]
        public TagInfo[] Tags{ get; set; }


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
        }
    }
}

