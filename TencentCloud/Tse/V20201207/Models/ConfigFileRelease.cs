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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigFileRelease : AbstractModel
    {
        
        /// <summary>
        /// <p>配置文件发布id</p>
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// <p>配置文件发布名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>配置文件发布命名空间</p>
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// <p>配置文件发布组</p>
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// <p>配置文件发布文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>配置文件发布内容</p>
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// <p>配置文件发布注释</p>
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// <p>配置文件发布Md5</p>
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// <p>配置文件发布版本</p>
        /// </summary>
        [JsonProperty("Version")]
        public ulong? Version{ get; set; }

        /// <summary>
        /// <p>配置文件发布创建时间</p>
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// <p>配置文件发布创建者</p>
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// <p>配置文件发布修改时间</p>
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// <p>配置文件发布修改者</p>
        /// </summary>
        [JsonProperty("ModifyBy")]
        public string ModifyBy{ get; set; }

        /// <summary>
        /// <p>发布描述</p>
        /// </summary>
        [JsonProperty("ReleaseDescription")]
        public string ReleaseDescription{ get; set; }

        /// <summary>
        /// <p>是否生效</p>
        /// </summary>
        [JsonProperty("Active")]
        public bool? Active{ get; set; }

        /// <summary>
        /// <p>格式</p>
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// <p>配置文件ID</p>
        /// </summary>
        [JsonProperty("ConfigFileId")]
        public string ConfigFileId{ get; set; }

        /// <summary>
        /// <p>配置文件类型</p>
        /// </summary>
        [JsonProperty("ConfigFileSupportedClient")]
        public long? ConfigFileSupportedClient{ get; set; }

        /// <summary>
        /// <p>配置文件持久化</p>
        /// </summary>
        [JsonProperty("ConfigFilePersistent")]
        public ConfigFilePersistent ConfigFilePersistent{ get; set; }

        /// <summary>
        /// <p>灰度标签</p>
        /// </summary>
        [JsonProperty("BetaLabels")]
        public BetaLabel[] BetaLabels{ get; set; }

        /// <summary>
        /// <p>发布类型</p><p>枚举值：</p><ul><li>gary： 灰度发布</li></ul>
        /// </summary>
        [JsonProperty("ReleaseType")]
        public string ReleaseType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Namespace", this.Namespace);
            this.SetParamSimple(map, prefix + "Group", this.Group);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Version", this.Version);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ModifyBy", this.ModifyBy);
            this.SetParamSimple(map, prefix + "ReleaseDescription", this.ReleaseDescription);
            this.SetParamSimple(map, prefix + "Active", this.Active);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "ConfigFileId", this.ConfigFileId);
            this.SetParamSimple(map, prefix + "ConfigFileSupportedClient", this.ConfigFileSupportedClient);
            this.SetParamObj(map, prefix + "ConfigFilePersistent.", this.ConfigFilePersistent);
            this.SetParamArrayObj(map, prefix + "BetaLabels.", this.BetaLabels);
            this.SetParamSimple(map, prefix + "ReleaseType", this.ReleaseType);
        }
    }
}

