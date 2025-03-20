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

namespace TencentCloud.Tse.V20201207.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ConfigFileRelease : AbstractModel
    {
        
        /// <summary>
        /// 配置文件发布id
        /// </summary>
        [JsonProperty("Id")]
        public ulong? Id{ get; set; }

        /// <summary>
        /// 配置文件发布名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 配置文件发布命名空间
        /// </summary>
        [JsonProperty("Namespace")]
        public string Namespace{ get; set; }

        /// <summary>
        /// 配置文件发布组
        /// </summary>
        [JsonProperty("Group")]
        public string Group{ get; set; }

        /// <summary>
        /// 配置文件发布文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 配置文件发布内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 配置文件发布注释
        /// </summary>
        [JsonProperty("Comment")]
        public string Comment{ get; set; }

        /// <summary>
        /// 配置文件发布Md5
        /// </summary>
        [JsonProperty("Md5")]
        public string Md5{ get; set; }

        /// <summary>
        /// 配置文件发布版本
        /// </summary>
        [JsonProperty("Version")]
        public ulong? Version{ get; set; }

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
        /// 是否生效
        /// </summary>
        [JsonProperty("Active")]
        public bool? Active{ get; set; }

        /// <summary>
        /// 格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 配置文件ID
        /// </summary>
        [JsonProperty("ConfigFileId")]
        public string ConfigFileId{ get; set; }

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
        }
    }
}

