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

namespace TencentCloud.Lighthouse.V20200324.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBlueprintRequest : AbstractModel
    {
        
        /// <summary>
        /// 镜像名称。最大长度60。
        /// </summary>
        [JsonProperty("BlueprintName")]
        public string BlueprintName{ get; set; }

        /// <summary>
        /// 镜像描述。最大长度60。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 需要制作镜像的实例ID。可通过 [DescribeInstances](https://cloud.tencent.com/document/api/1207/47573) 接口返回值中的 InstanceId 获取。
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 是否执行强制关机以制作镜像。
        /// 取值范围：
        /// True：表示关机之后制作镜像
        /// False：表示开机状态制作镜像
        /// 默认取值：True
        /// 开机状态制作镜像，可能导致部分数据未备份，影响数据安全。
        /// </summary>
        [JsonProperty("ForcePowerOff")]
        public bool? ForcePowerOff{ get; set; }

        /// <summary>
        /// 标签键和标签值。 如果指定多个标签，则会为指定资源同时创建并绑定该多个标签。 同一个资源上的同一个标签键只能对应一个标签值。如果您尝试添加已有标签键，则对应的标签值会更新为新值。 如果标签不存在会为您自动创建标签。 数组最多支持10个元素。
        /// </summary>
        [JsonProperty("Tags")]
        public Tag[] Tags{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BlueprintName", this.BlueprintName);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamSimple(map, prefix + "ForcePowerOff", this.ForcePowerOff);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
        }
    }
}

