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

namespace TencentCloud.Cds.V20180420.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAssetsListRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>限制数目</p>
        /// </summary>
        [JsonProperty("Limit")]
        public long? Limit{ get; set; }

        /// <summary>
        /// <p>偏移量</p>
        /// </summary>
        [JsonProperty("Offset")]
        public long? Offset{ get; set; }

        /// <summary>
        /// <p>实例Id/实例名称/资产名称</p>
        /// </summary>
        [JsonProperty("SearchValues")]
        public NameValueString[] SearchValues{ get; set; }

        /// <summary>
        /// <p>数据资产类型</p>
        /// </summary>
        [JsonProperty("AssetsType")]
        public string AssetsType{ get; set; }

        /// <summary>
        /// <p>查询的资产类型（1:cdb、2:cvm、3:others）</p>
        /// </summary>
        [JsonProperty("AssetsAddType")]
        public long? AssetsAddType{ get; set; }

        /// <summary>
        /// <p>地域</p>
        /// </summary>
        [JsonProperty("RegionId")]
        public string RegionId{ get; set; }

        /// <summary>
        /// <p>审计权限</p>
        /// </summary>
        [JsonProperty("Permission")]
        public long? Permission{ get; set; }

        /// <summary>
        /// <p>状态</p>
        /// </summary>
        [JsonProperty("AliveStatus")]
        public long? AliveStatus{ get; set; }

        /// <summary>
        /// <p>1.代理开启 0.代理关闭 -1.全查</p>
        /// </summary>
        [JsonProperty("CasbOn")]
        public long? CasbOn{ get; set; }

        /// <summary>
        /// <p>1.Agent开启 0.Agent关闭 -1.全查</p>
        /// </summary>
        [JsonProperty("AgentOn")]
        public long? AgentOn{ get; set; }

        /// <summary>
        /// <p>0.关闭，1.开启，2.关闭中，3.开启中 -1.全查</p>
        /// </summary>
        [JsonProperty("CdbOn")]
        public long? CdbOn{ get; set; }

        /// <summary>
        /// <p>扩展分类，如sensitive，指定查询支持敏感数据识别的资产</p>
        /// </summary>
        [JsonProperty("ExtendCategory")]
        public string ExtendCategory{ get; set; }

        /// <summary>
        /// <p>资产组Id（Id=0 暂未分组；id&gt;0 组Id）</p>
        /// </summary>
        [JsonProperty("GroupIds")]
        public ulong?[] GroupIds{ get; set; }

        /// <summary>
        /// <p>资产Id</p>
        /// </summary>
        [JsonProperty("Aids")]
        public ulong?[] Aids{ get; set; }

        /// <summary>
        /// <p>查询绑定状态（1:查询规则绑定数量；2:查询模型绑定数量）</p>
        /// </summary>
        [JsonProperty("BindingState")]
        public ulong? BindingState{ get; set; }

        /// <summary>
        /// <p>网卡是否开启流量审计</p><p>取值范围：[-1, 1]</p>
        /// </summary>
        [JsonProperty("TrafficMirrorOn")]
        public long? TrafficMirrorOn{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamArrayObj(map, prefix + "SearchValues.", this.SearchValues);
            this.SetParamSimple(map, prefix + "AssetsType", this.AssetsType);
            this.SetParamSimple(map, prefix + "AssetsAddType", this.AssetsAddType);
            this.SetParamSimple(map, prefix + "RegionId", this.RegionId);
            this.SetParamSimple(map, prefix + "Permission", this.Permission);
            this.SetParamSimple(map, prefix + "AliveStatus", this.AliveStatus);
            this.SetParamSimple(map, prefix + "CasbOn", this.CasbOn);
            this.SetParamSimple(map, prefix + "AgentOn", this.AgentOn);
            this.SetParamSimple(map, prefix + "CdbOn", this.CdbOn);
            this.SetParamSimple(map, prefix + "ExtendCategory", this.ExtendCategory);
            this.SetParamArraySimple(map, prefix + "GroupIds.", this.GroupIds);
            this.SetParamArraySimple(map, prefix + "Aids.", this.Aids);
            this.SetParamSimple(map, prefix + "BindingState", this.BindingState);
            this.SetParamSimple(map, prefix + "TrafficMirrorOn", this.TrafficMirrorOn);
        }
    }
}

