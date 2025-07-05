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

    public class ConfigFileReleaseHistory : AbstractModel
    {
        
        /// <summary>
        /// 配置文件发布历史记录id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 配置文件发布历史名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 配置文件发布历史命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 配置文件发布历史组
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 配置文件发布历史名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 配置文件发布历史内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 配置文件发布历史格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 配置文件发布历史注释
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 配置文件发布历史Md5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 配置文件发布历史类型
        /// </summary>
        [JsonProperty("Type")]
        public string Type{ get; set; }

        /// <summary>
        /// 配置文件发布历史状态
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 配置文件发布历史标签组
        /// </summary>
        [JsonProperty("Tags")]
        public ConfigFileTag[] Tags{ get; set; }

        /// <summary>
        /// 配置文件发布创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 配置文件发布创建者
        /// </summary>
        [JsonProperty("CreateBy")]
        public string CreateBy{ get; set; }

        /// <summary>
        /// 配置文件发布修改时间
        /// </summary>
        [JsonProperty("ModifyTime")]
        public string ModifyTime{ get; set; }

        /// <summary>
        /// 配置文件发布修改者
        /// </summary>
        [JsonProperty("ModifyBy")]
        public string ModifyBy{ get; set; }

        /// <summary>
        /// 发布描述
        /// </summary>
        [JsonProperty("ReleaseDescription")]
        public string ReleaseDescription{ get; set; }

        /// <summary>
        /// 原因，用于失败时原因展示
        /// </summary>
        [JsonProperty("ReleaseReason")]
        public string ReleaseReason{ get; set; }

        /// <summary>
        /// 配置文件类型
        /// </summary>
        [JsonProperty("ConfigFileSupportedClient")]
        public long? ConfigFileSupportedClient{ get; set; }

        /// <summary>
        /// 配置文件持久化
        /// </summary>
        [JsonProperty("ConfigFilePersistent")]
        public ConfigFilePersistent ConfigFilePersistent{ get; set; }


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
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Comment", this.Comment);
            this.SetParamSimple(map, prefix + "Md5", this.Md5);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArrayObj(map, prefix + "Tags.", this.Tags);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CreateBy", this.CreateBy);
            this.SetParamSimple(map, prefix + "ModifyTime", this.ModifyTime);
            this.SetParamSimple(map, prefix + "ModifyBy", this.ModifyBy);
            this.SetParamSimple(map, prefix + "ReleaseDescription", this.ReleaseDescription);
            this.SetParamSimple(map, prefix + "ReleaseReason", this.ReleaseReason);
            this.SetParamSimple(map, prefix + "ConfigFileSupportedClient", this.ConfigFileSupportedClient);
            this.SetParamObj(map, prefix + "ConfigFilePersistent.", this.ConfigFilePersistent);
        }
    }
}

