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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>日志时间，单位ms</p>
        /// </summary>
        [JsonProperty("Time")]
        public long? Time{ get; set; }

        /// <summary>
        /// <p>日志主题ID</p>
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// <p>日志主题名称</p>
        /// </summary>
        [JsonProperty("TopicName")]
        public string TopicName{ get; set; }

        /// <summary>
        /// <p>日志来源IP</p>
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// <p>日志文件名称</p>
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// <p>日志上报请求包的ID</p>
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// <p>请求包内日志的ID</p>
        /// </summary>
        [JsonProperty("PkgLogId")]
        public string PkgLogId{ get; set; }

        /// <summary>
        /// <p>符合检索条件的关键词，一般用于高亮显示。仅支持键值检索，不支持全文检索</p>
        /// </summary>
        [JsonProperty("HighLights")]
        public HighLightItem[] HighLights{ get; set; }

        /// <summary>
        /// <p>日志内容的Json序列化字符串</p>
        /// </summary>
        [JsonProperty("LogJson")]
        public string LogJson{ get; set; }

        /// <summary>
        /// <p>日志来源主机名称</p>
        /// </summary>
        [JsonProperty("HostName")]
        public string HostName{ get; set; }

        /// <summary>
        /// <p>原始日志(仅在日志创建索引异常时有值)</p>
        /// </summary>
        [JsonProperty("RawLog")]
        public string RawLog{ get; set; }

        /// <summary>
        /// <p>日志创建索引异常原因(仅在日志创建索引异常时有值)</p>
        /// </summary>
        [JsonProperty("IndexStatus")]
        public string IndexStatus{ get; set; }

        /// <summary>
        /// <p>日志时间，单位ns</p><p>单位：纳秒</p>
        /// </summary>
        [JsonProperty("TimeNanos")]
        public long? TimeNanos{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Time", this.Time);
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "TopicName", this.TopicName);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "PkgLogId", this.PkgLogId);
            this.SetParamArrayObj(map, prefix + "HighLights.", this.HighLights);
            this.SetParamSimple(map, prefix + "LogJson", this.LogJson);
            this.SetParamSimple(map, prefix + "HostName", this.HostName);
            this.SetParamSimple(map, prefix + "RawLog", this.RawLog);
            this.SetParamSimple(map, prefix + "IndexStatus", this.IndexStatus);
            this.SetParamSimple(map, prefix + "TimeNanos", this.TimeNanos);
        }
    }
}

