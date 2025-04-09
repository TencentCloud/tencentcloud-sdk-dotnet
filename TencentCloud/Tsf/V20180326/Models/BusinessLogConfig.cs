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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class BusinessLogConfig : AbstractModel
    {
        
        /// <summary>
        /// 配置项ID
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 配置项名称
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置项日志路径
        /// </summary>
        [JsonProperty("ConfigPath")]
        public string ConfigPath{ get; set; }

        /// <summary>
        /// 配置项描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigDesc")]
        public string ConfigDesc{ get; set; }

        /// <summary>
        /// 配置项标签
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigTags")]
        public string ConfigTags{ get; set; }

        /// <summary>
        /// 配置项对应的ES管道
        /// </summary>
        [JsonProperty("ConfigPipeline")]
        public string ConfigPipeline{ get; set; }

        /// <summary>
        /// 配置项创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigCreateTime")]
        public string ConfigCreateTime{ get; set; }

        /// <summary>
        /// 配置项更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigUpdateTime")]
        public string ConfigUpdateTime{ get; set; }

        /// <summary>
        /// 配置项解析规则
        /// </summary>
        [JsonProperty("ConfigSchema")]
        public BusinessLogConfigSchema ConfigSchema{ get; set; }

        /// <summary>
        /// 配置项关联部署组
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigAssociatedGroups")]
        [System.Obsolete]
        public BusinesLogConfigAssociatedGroup[] ConfigAssociatedGroups{ get; set; }

        /// <summary>
        /// 配置项关联部署组
        /// </summary>
        [JsonProperty("ConfigAssociatedGroupList")]
        public BusinessLogConfigAssociatedGroup[] ConfigAssociatedGroupList{ get; set; }

        /// <summary>
        /// 是否开启filebeat高级配置开关
        /// </summary>
        [JsonProperty("FilebeatConfigEnable")]
        public bool? FilebeatConfigEnable{ get; set; }

        /// <summary>
        /// close_timeout参数
        /// </summary>
        [JsonProperty("FilebeatCloseTimeout")]
        public long? FilebeatCloseTimeout{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigPath", this.ConfigPath);
            this.SetParamSimple(map, prefix + "ConfigDesc", this.ConfigDesc);
            this.SetParamSimple(map, prefix + "ConfigTags", this.ConfigTags);
            this.SetParamSimple(map, prefix + "ConfigPipeline", this.ConfigPipeline);
            this.SetParamSimple(map, prefix + "ConfigCreateTime", this.ConfigCreateTime);
            this.SetParamSimple(map, prefix + "ConfigUpdateTime", this.ConfigUpdateTime);
            this.SetParamObj(map, prefix + "ConfigSchema.", this.ConfigSchema);
            this.SetParamArrayObj(map, prefix + "ConfigAssociatedGroups.", this.ConfigAssociatedGroups);
            this.SetParamArrayObj(map, prefix + "ConfigAssociatedGroupList.", this.ConfigAssociatedGroupList);
            this.SetParamSimple(map, prefix + "FilebeatConfigEnable", this.FilebeatConfigEnable);
            this.SetParamSimple(map, prefix + "FilebeatCloseTimeout", this.FilebeatCloseTimeout);
        }
    }
}

