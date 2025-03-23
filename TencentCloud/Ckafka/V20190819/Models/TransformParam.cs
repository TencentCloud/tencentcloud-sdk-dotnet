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

namespace TencentCloud.Ckafka.V20190819.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class TransformParam : AbstractModel
    {
        
        /// <summary>
        /// 解析格式，JSON，DELIMITER分隔符，REGULAR正则提取
        /// </summary>
        [JsonProperty("AnalysisFormat")]
        public string AnalysisFormat{ get; set; }

        /// <summary>
        /// 输出格式
        /// </summary>
        [JsonProperty("OutputFormat")]
        public string OutputFormat{ get; set; }

        /// <summary>
        /// 是否保留解析失败数据
        /// </summary>
        [JsonProperty("FailureParam")]
        public FailureParam FailureParam{ get; set; }

        /// <summary>
        /// 原始数据
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 数据来源，TOPIC从源topic拉取，CUSTOMIZE自定义
        /// </summary>
        [JsonProperty("SourceType")]
        public string SourceType{ get; set; }

        /// <summary>
        /// 分隔符、正则表达式
        /// </summary>
        [JsonProperty("Regex")]
        public string Regex{ get; set; }

        /// <summary>
        /// Map
        /// </summary>
        [JsonProperty("MapParam")]
        public MapParam[] MapParam{ get; set; }

        /// <summary>
        /// 过滤器
        /// </summary>
        [JsonProperty("FilterParam")]
        public FilterMapParam[] FilterParam{ get; set; }

        /// <summary>
        /// 测试结果
        /// </summary>
        [JsonProperty("Result")]
        public string Result{ get; set; }

        /// <summary>
        /// 解析结果
        /// </summary>
        [JsonProperty("AnalyseResult")]
        public MapParam[] AnalyseResult{ get; set; }

        /// <summary>
        /// 底层引擎是否使用eb
        /// </summary>
        [JsonProperty("UseEventBus")]
        public bool? UseEventBus{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "AnalysisFormat", this.AnalysisFormat);
            this.SetParamSimple(map, prefix + "OutputFormat", this.OutputFormat);
            this.SetParamObj(map, prefix + "FailureParam.", this.FailureParam);
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
            this.SetParamSimple(map, prefix + "Regex", this.Regex);
            this.SetParamArrayObj(map, prefix + "MapParam.", this.MapParam);
            this.SetParamArrayObj(map, prefix + "FilterParam.", this.FilterParam);
            this.SetParamSimple(map, prefix + "Result", this.Result);
            this.SetParamArrayObj(map, prefix + "AnalyseResult.", this.AnalyseResult);
            this.SetParamSimple(map, prefix + "UseEventBus", this.UseEventBus);
        }
    }
}

