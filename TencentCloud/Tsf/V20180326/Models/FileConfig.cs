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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class FileConfig : AbstractModel
    {
        
        /// <summary>
        /// 配置项ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 配置项名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigName")]
        public string ConfigName{ get; set; }

        /// <summary>
        /// 配置项版本
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigVersion")]
        public string ConfigVersion{ get; set; }

        /// <summary>
        /// 配置项版本描述
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigVersionDesc")]
        public string ConfigVersionDesc{ get; set; }

        /// <summary>
        /// 配置项文件名
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigFileName")]
        public string ConfigFileName{ get; set; }

        /// <summary>
        /// 配置项文件内容
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigFileValue")]
        public string ConfigFileValue{ get; set; }

        /// <summary>
        /// 配置项文件编码
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigFileCode")]
        public string ConfigFileCode{ get; set; }

        /// <summary>
        /// 创建时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("CreationTime")]
        public string CreationTime{ get; set; }

        /// <summary>
        /// 配置项归属应用ID
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 删除标识
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("DeleteFlag")]
        public bool? DeleteFlag{ get; set; }

        /// <summary>
        /// 配置项版本数量
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigVersionCount")]
        public long? ConfigVersionCount{ get; set; }

        /// <summary>
        /// 配置项最后更新时间
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LastUpdateTime")]
        public string LastUpdateTime{ get; set; }

        /// <summary>
        /// 发布路径
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigFilePath")]
        public string ConfigFilePath{ get; set; }

        /// <summary>
        /// 后置命令
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigPostCmd")]
        public string ConfigPostCmd{ get; set; }

        /// <summary>
        /// 配置项文件长度
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("ConfigFileValueLength")]
        public ulong? ConfigFileValueLength{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "ConfigName", this.ConfigName);
            this.SetParamSimple(map, prefix + "ConfigVersion", this.ConfigVersion);
            this.SetParamSimple(map, prefix + "ConfigVersionDesc", this.ConfigVersionDesc);
            this.SetParamSimple(map, prefix + "ConfigFileName", this.ConfigFileName);
            this.SetParamSimple(map, prefix + "ConfigFileValue", this.ConfigFileValue);
            this.SetParamSimple(map, prefix + "ConfigFileCode", this.ConfigFileCode);
            this.SetParamSimple(map, prefix + "CreationTime", this.CreationTime);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamSimple(map, prefix + "DeleteFlag", this.DeleteFlag);
            this.SetParamSimple(map, prefix + "ConfigVersionCount", this.ConfigVersionCount);
            this.SetParamSimple(map, prefix + "LastUpdateTime", this.LastUpdateTime);
            this.SetParamSimple(map, prefix + "ConfigFilePath", this.ConfigFilePath);
            this.SetParamSimple(map, prefix + "ConfigPostCmd", this.ConfigPostCmd);
            this.SetParamSimple(map, prefix + "ConfigFileValueLength", this.ConfigFileValueLength);
        }
    }
}

