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

namespace TencentCloud.Scf.V20180416.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TriggerInfo : AbstractModel
    {
        
        /// <summary>
        /// 使能开关
        /// </summary>
        [JsonProperty("Enable")]
        public ulong? Enable{ get; set; }

        /// <summary>
        /// 函数版本或别名
        /// </summary>
        [JsonProperty("Qualifier")]
        public string Qualifier{ get; set; }

        /// <summary>
        /// 触发器名称
        /// </summary>
        [JsonProperty("TriggerName")]
        public string TriggerName{ get; set; }

        /// <summary>
        /// 触发器类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 触发器详细配置
        /// </summary>
        [JsonProperty("TriggerDesc")]
        public string TriggerDesc{ get; set; }

        /// <summary>
        /// 触发器是否可用
        /// </summary>
        [JsonProperty("AvailableStatus")]
        public string AvailableStatus{ get; set; }

        /// <summary>
        /// 客户自定义参数
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CustomArgument")]
        public string CustomArgument{ get; set; }

        /// <summary>
        /// 触发器创建时间
        /// </summary>
        [JsonProperty("AddTime")]
        public string AddTime{ get; set; }

        /// <summary>
        /// 触发器最后修改时间
        /// </summary>
        [JsonProperty("ModTime")]
        public string ModTime{ get; set; }

        /// <summary>
        /// 触发器最小资源ID
        /// </summary>
        [JsonProperty("ResourceId")]
        [System.Obsolete]
        public string ResourceId{ get; set; }

        /// <summary>
        /// 触发器和云函数绑定状态
        /// </summary>
        [JsonProperty("BindStatus")]
        [System.Obsolete]
        public string BindStatus{ get; set; }

        /// <summary>
        /// 触发器类型，双向表示两侧控制台均可操作，单向表示SCF控制台单向创建
        /// </summary>
        [JsonProperty("TriggerAttribute")]
        [System.Obsolete]
        public string TriggerAttribute{ get; set; }

        /// <summary>
        /// 客户自定义触发器描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 与此触发器关联的资源。目前仅函数URL关联的自定义域名会返回
        /// </summary>
        [JsonProperty("BoundResources")]
        public string BoundResources{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Enable", this.Enable);
            this.SetParamSimple(map, prefix + "Qualifier", this.Qualifier);
            this.SetParamSimple(map, prefix + "TriggerName", this.TriggerName);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "TriggerDesc", this.TriggerDesc);
            this.SetParamSimple(map, prefix + "AvailableStatus", this.AvailableStatus);
            this.SetParamSimple(map, prefix + "CustomArgument", this.CustomArgument);
            this.SetParamSimple(map, prefix + "AddTime", this.AddTime);
            this.SetParamSimple(map, prefix + "ModTime", this.ModTime);
            this.SetParamSimple(map, prefix + "ResourceId", this.ResourceId);
            this.SetParamSimple(map, prefix + "BindStatus", this.BindStatus);
            this.SetParamSimple(map, prefix + "TriggerAttribute", this.TriggerAttribute);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "BoundResources", this.BoundResources);
        }
    }
}

