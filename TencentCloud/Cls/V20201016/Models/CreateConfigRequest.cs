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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateConfigRequest : AbstractModel
    {
        
        /// <summary>
        /// 采集配置名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 采集配置所属日志主题ID即TopicId
        /// </summary>
        [JsonProperty("Output")]
        public string Output{ get; set; }

        /// <summary>
        /// 日志采集路径,包含文件名
        /// </summary>
        [JsonProperty("Path")]
        public string Path{ get; set; }

        /// <summary>
        /// 采集的日志类型，json_log代表json格式日志，delimiter_log代表分隔符格式日志，minimalist_log代表极简日志，multiline_log代表多行日志，fullregex_log代表完整正则，默认为minimalist_log
        /// </summary>
        [JsonProperty("LogType")]
        public string LogType{ get; set; }

        /// <summary>
        /// 提取规则，如果设置了ExtractRule，则必须设置LogType
        /// </summary>
        [JsonProperty("ExtractRule")]
        public ExtractRuleInfo ExtractRule{ get; set; }

        /// <summary>
        /// 采集黑名单路径列表
        /// </summary>
        [JsonProperty("ExcludePaths")]
        public ExcludePathInfo[] ExcludePaths{ get; set; }

        /// <summary>
        /// 用户自定义采集规则，Json格式序列化的字符串
        /// </summary>
        [JsonProperty("UserDefineRule")]
        public string UserDefineRule{ get; set; }

        /// <summary>
        /// 高级采集配置
        /// </summary>
        [JsonProperty("AdvancedConfig")]
        public string AdvancedConfig{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Output", this.Output);
            this.SetParamSimple(map, prefix + "Path", this.Path);
            this.SetParamSimple(map, prefix + "LogType", this.LogType);
            this.SetParamObj(map, prefix + "ExtractRule.", this.ExtractRule);
            this.SetParamArrayObj(map, prefix + "ExcludePaths.", this.ExcludePaths);
            this.SetParamSimple(map, prefix + "UserDefineRule", this.UserDefineRule);
            this.SetParamSimple(map, prefix + "AdvancedConfig", this.AdvancedConfig);
        }
    }
}

