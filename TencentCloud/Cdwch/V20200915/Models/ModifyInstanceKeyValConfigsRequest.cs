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

namespace TencentCloud.Cdwch.V20200915.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyInstanceKeyValConfigsRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("InstanceId")]
        public string InstanceId{ get; set; }

        /// <summary>
        /// 新增配置列表
        /// </summary>
        [JsonProperty("AddItems")]
        public InstanceConfigItem[] AddItems{ get; set; }

        /// <summary>
        /// 更新配置列表
        /// </summary>
        [JsonProperty("UpdateItems")]
        public InstanceConfigItem[] UpdateItems{ get; set; }

        /// <summary>
        /// 删除配置列表
        /// </summary>
        [JsonProperty("DeleteItems")]
        public InstanceConfigItem DeleteItems{ get; set; }

        /// <summary>
        /// 删除配置列表
        /// </summary>
        [JsonProperty("DelItems")]
        public InstanceConfigItem[] DelItems{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "InstanceId", this.InstanceId);
            this.SetParamArrayObj(map, prefix + "AddItems.", this.AddItems);
            this.SetParamArrayObj(map, prefix + "UpdateItems.", this.UpdateItems);
            this.SetParamObj(map, prefix + "DeleteItems.", this.DeleteItems);
            this.SetParamArrayObj(map, prefix + "DelItems.", this.DelItems);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
        }
    }
}

