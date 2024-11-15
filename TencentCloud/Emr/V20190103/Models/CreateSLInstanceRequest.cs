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

namespace TencentCloud.Emr.V20190103.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateSLInstanceRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("InstanceName")]
        public string InstanceName{ get; set; }

        /// <summary>
        /// 实例计费模式，0表示后付费，即按量计费。
        /// </summary>
        [JsonProperty("PayMode")]
        public long? PayMode{ get; set; }

        /// <summary>
        /// 实例存储类型，填写CLOUD_HSSD，表示性能云存储。
        /// </summary>
        [JsonProperty("DiskType")]
        public string DiskType{ get; set; }

        /// <summary>
        /// 实例单节点磁盘容量，单位GB，单节点磁盘容量需大于等于100，小于等于10000，容量调整步长为20。
        /// </summary>
        [JsonProperty("DiskSize")]
        public long? DiskSize{ get; set; }

        /// <summary>
        /// 实例节点规格，可填写4C16G、8C32G、16C64G、32C128G，不区分大小写。
        /// </summary>
        [JsonProperty("NodeType")]
        public string NodeType{ get; set; }

        /// <summary>
        /// 实例可用区详细配置，当前支持多可用区，可用区数量只能为1或3，包含区域名称，VPC信息、节点数量，其中所有区域节点总数需大于等于3，小于等于50。
        /// </summary>
        [JsonProperty("ZoneSettings")]
        public ZoneSetting[] ZoneSettings{ get; set; }

        /// <summary>
        /// 实例要绑定的标签列表。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }

        /// <summary>
        /// 预付费参数
        /// </summary>
        [JsonProperty("PrePaySetting")]
        public PrePaySetting PrePaySetting{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceName", this.InstanceName);
            this.SetParamSimple(map, prefix + "PayMode", this.PayMode);
            this.SetParamSimple(map, prefix + "DiskType", this.DiskType);
            this.SetParamSimple(map, prefix + "DiskSize", this.DiskSize);
            this.SetParamSimple(map, prefix + "NodeType", this.NodeType);
            this.SetParamArrayObj(map, prefix + "ZoneSettings.", this.ZoneSettings);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamObj(map, prefix + "PrePaySetting.", this.PrePaySetting);
        }
    }
}

