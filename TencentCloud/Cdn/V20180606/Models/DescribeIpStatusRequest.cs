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

namespace TencentCloud.Cdn.V20180606.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeIpStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 加速域名
        /// </summary>
        [JsonProperty("Domain")]
        public string Domain{ get; set; }

        /// <summary>
        /// 节点类型：
        /// edge：表示边缘节点
        /// last：表示回源层节点
        /// 不填充情况下，默认返回边缘节点信息
        /// </summary>
        [JsonProperty("Layer")]
        public string Layer{ get; set; }

        /// <summary>
        /// 查询区域：
        /// mainland: 国内节点
        /// overseas: 海外节点
        /// global: 全球节点
        /// </summary>
        [JsonProperty("Area")]
        public string Area{ get; set; }

        /// <summary>
        /// 是否以IP段的格式返回。
        /// </summary>
        [JsonProperty("Segment")]
        public bool? Segment{ get; set; }

        /// <summary>
        /// 是否查询节点 IPV6 信息。
        /// </summary>
        [JsonProperty("ShowIpv6")]
        public bool? ShowIpv6{ get; set; }

        /// <summary>
        /// 是否对IPV6进行缩写。
        /// </summary>
        [JsonProperty("AbbreviationIpv6")]
        public bool? AbbreviationIpv6{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Domain", this.Domain);
            this.SetParamSimple(map, prefix + "Layer", this.Layer);
            this.SetParamSimple(map, prefix + "Area", this.Area);
            this.SetParamSimple(map, prefix + "Segment", this.Segment);
            this.SetParamSimple(map, prefix + "ShowIpv6", this.ShowIpv6);
            this.SetParamSimple(map, prefix + "AbbreviationIpv6", this.AbbreviationIpv6);
        }
    }
}

