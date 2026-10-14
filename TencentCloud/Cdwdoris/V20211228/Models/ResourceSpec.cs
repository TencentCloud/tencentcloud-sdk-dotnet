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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ResourceSpec : AbstractModel
    {
        
        /// <summary>
        /// <p>规格名称，例如“SCH1&quot;</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>cpu核数</p>
        /// </summary>
        [JsonProperty("Cpu")]
        public long? Cpu{ get; set; }

        /// <summary>
        /// <p>内存大小，单位G</p>
        /// </summary>
        [JsonProperty("Mem")]
        public long? Mem{ get; set; }

        /// <summary>
        /// <p>分类标记，STANDARD/BIGDATA/HIGHIO分别表示标准型/大数据型/高IO</p>
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// <p>系统盘描述信息</p>
        /// </summary>
        [JsonProperty("SystemDisk")]
        public DiskSpec SystemDisk{ get; set; }

        /// <summary>
        /// <p>数据盘描述信息</p>
        /// </summary>
        [JsonProperty("DataDisk")]
        public DiskSpec DataDisk{ get; set; }

        /// <summary>
        /// <p>最大节点数目限制</p>
        /// </summary>
        [JsonProperty("MaxNodeSize")]
        public long? MaxNodeSize{ get; set; }

        /// <summary>
        /// <p>是否可用，false代表售罄</p>
        /// </summary>
        [JsonProperty("Available")]
        public bool? Available{ get; set; }

        /// <summary>
        /// <p>规格描述信息</p>
        /// </summary>
        [JsonProperty("ComputeSpecDesc")]
        public string ComputeSpecDesc{ get; set; }

        /// <summary>
        /// <p>cvm库存</p>
        /// </summary>
        [JsonProperty("InstanceQuota")]
        public long? InstanceQuota{ get; set; }

        /// <summary>
        /// <p>计算组ID自定义后缀。1到8位小写字母、数字或连字符，首尾须为字母或数字；不传则随机生成8位后缀。最终计算组ID格式为实例ID-后缀，同时作为内核计算组名</p>
        /// </summary>
        [JsonProperty("ComputeGroupSuffix")]
        public string ComputeGroupSuffix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Cpu", this.Cpu);
            this.SetParamSimple(map, prefix + "Mem", this.Mem);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamObj(map, prefix + "SystemDisk.", this.SystemDisk);
            this.SetParamObj(map, prefix + "DataDisk.", this.DataDisk);
            this.SetParamSimple(map, prefix + "MaxNodeSize", this.MaxNodeSize);
            this.SetParamSimple(map, prefix + "Available", this.Available);
            this.SetParamSimple(map, prefix + "ComputeSpecDesc", this.ComputeSpecDesc);
            this.SetParamSimple(map, prefix + "InstanceQuota", this.InstanceQuota);
            this.SetParamSimple(map, prefix + "ComputeGroupSuffix", this.ComputeGroupSuffix);
        }
    }
}

