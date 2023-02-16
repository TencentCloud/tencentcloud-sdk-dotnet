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

namespace TencentCloud.Tem.V20210701.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class LogConfigExtractRule : AbstractModel
    {
        
        /// <summary>
        /// 首行正则表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("BeginningRegex")]
        public string BeginningRegex{ get; set; }

        /// <summary>
        /// 提取结果
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// 过滤键
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterKeys")]
        public string[] FilterKeys{ get; set; }

        /// <summary>
        /// 过滤值
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("FilterRegex")]
        public string[] FilterRegex{ get; set; }

        /// <summary>
        /// 日志正则表达式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// 时间字段
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// 时间格式
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// 是否上传解析失败日志
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchUpload")]
        public string UnMatchUpload{ get; set; }

        /// <summary>
        /// 解析失败日志的键名称
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("UnMatchedKey")]
        public string UnMatchedKey{ get; set; }

        /// <summary>
        /// tracking
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Backtracking")]
        public string Backtracking{ get; set; }

        /// <summary>
        /// 分隔符
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BeginningRegex", this.BeginningRegex);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamArraySimple(map, prefix + "FilterKeys.", this.FilterKeys);
            this.SetParamArraySimple(map, prefix + "FilterRegex.", this.FilterRegex);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "UnMatchUpload", this.UnMatchUpload);
            this.SetParamSimple(map, prefix + "UnMatchedKey", this.UnMatchedKey);
            this.SetParamSimple(map, prefix + "Backtracking", this.Backtracking);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
        }
    }
}

