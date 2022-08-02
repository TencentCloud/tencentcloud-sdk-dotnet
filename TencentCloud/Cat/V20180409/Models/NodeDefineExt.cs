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

namespace TencentCloud.Cat.V20180409.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NodeDefineExt : AbstractModel
    {
        
        /// <summary>
        /// 节点名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 节点代码
        /// </summary>
        [JsonProperty("Code")]
        public string Code{ get; set; }

        /// <summary>
        /// 节点类型
        /// <li> 1 = IDC </li>
        /// <li> 2 = LastMile </li>
        /// <li> 3 = Mobile </li>
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 网络服务商
        /// </summary>
        [JsonProperty("NetService")]
        public string NetService{ get; set; }

        /// <summary>
        /// 区域
        /// </summary>
        [JsonProperty("District")]
        public string District{ get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("City")]
        public string City{ get; set; }

        /// <summary>
        /// IP 类型
        /// <li> 1 = IPv4 </li>
        /// <li> 2 = IPv6 </li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IPType")]
        public long? IPType{ get; set; }

        /// <summary>
        /// 区域
        /// <li> 1 = 中国大陆 </li>
        /// <li> 2 = 港澳台 </li>
        /// <li> 3 = 国外 </li>
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Location")]
        public long? Location{ get; set; }

        /// <summary>
        /// 节点类型  如果为base 则为可用性拨测点，为空则为高级拨测点
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CodeType")]
        public string CodeType{ get; set; }

        /// <summary>
        /// 节点支持的任务类型。1: 页面性能 2: 文件上传 3: 文件下载 4: 端口性能 5: 网络质量 6: 音视频体验
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TaskTypes")]
        public long?[] TaskTypes{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Code", this.Code);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "NetService", this.NetService);
            this.SetParamSimple(map, prefix + "District", this.District);
            this.SetParamSimple(map, prefix + "City", this.City);
            this.SetParamSimple(map, prefix + "IPType", this.IPType);
            this.SetParamSimple(map, prefix + "Location", this.Location);
            this.SetParamSimple(map, prefix + "CodeType", this.CodeType);
            this.SetParamArraySimple(map, prefix + "TaskTypes.", this.TaskTypes);
        }
    }
}

