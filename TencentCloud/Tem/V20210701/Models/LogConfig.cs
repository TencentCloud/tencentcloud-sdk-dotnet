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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogConfig : AbstractModel
    {
        
        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 收集类型，container_stdout 为标准输出；container_file 为文件；
        /// </summary>
        [JsonProperty("InputType")]
        public string InputType{ get; set; }

        /// <summary>
        /// 日志集 ID
        /// </summary>
        [JsonProperty("LogsetId")]
        public string LogsetId{ get; set; }

        /// <summary>
        /// 日志主题 ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志提取模式，minimalist_log 为单行全文；multiline_log 为多行全文；  fullregex_log 为单行正则； multiline_fullregex_log 为多行正则； json_log 为 json；
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 首行正则表达式，当 LogType 为多行全文、多行正则时生效
        /// </summary>
        [JsonProperty("BeginningRegex")]
        public string BeginningRegex{ get; set; }

        /// <summary>
        /// 收集文件目录，当 InputType=container_file 时生效
        /// </summary>
        [JsonProperty("LogPath")]
        public string LogPath{ get; set; }

        /// <summary>
        /// 收集文件名模式，当 InputType=container_file 时生效
        /// </summary>
        [JsonProperty("FilePattern")]
        public string FilePattern{ get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        [JsonProperty("CreateDate")]
        public string CreateDate{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("ModifyDate")]
        public string ModifyDate{ get; set; }

        /// <summary>
        /// 应用 ID
        /// </summary>
        [JsonProperty("ApplicationId")]
        public string ApplicationId{ get; set; }

        /// <summary>
        /// 应用名
        /// </summary>
        [JsonProperty("ApplicationName")]
        public string ApplicationName{ get; set; }

        /// <summary>
        /// 导出规则
        /// </summary>
        [JsonProperty("ExtractRule")]
        public LogConfigExtractRule ExtractRule{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "InputType", this.InputType);
            this.SetParamSimple(map, prefix + "LogsetId", this.LogsetId);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamSimple(map, prefix + "BeginningRegex", this.BeginningRegex);
            this.SetParamSimple(map, prefix + "LogPath", this.LogPath);
            this.SetParamSimple(map, prefix + "FilePattern", this.FilePattern);
            this.SetParamSimple(map, prefix + "CreateDate", this.CreateDate);
            this.SetParamSimple(map, prefix + "ModifyDate", this.ModifyDate);
            this.SetParamSimple(map, prefix + "ApplicationId", this.ApplicationId);
            this.SetParamSimple(map, prefix + "ApplicationName", this.ApplicationName);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
        }
    }
}

