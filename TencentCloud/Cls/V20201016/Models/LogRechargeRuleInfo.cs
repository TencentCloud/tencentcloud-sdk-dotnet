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

    public class LogRechargeRuleInfo : AbstractModel
    {
        
        /// <summary>
        /// <p>导入类型，支持json_log：json格式日志，minimalist_log: 单行全文，fullregex_log: 单行完全正则</p>
        /// </summary>
        [JsonProperty("RechargeType")]
        public string RechargeType{ get; set; }

        /// <summary>
        /// <p>解析编码格式，0: UTF-8（默认值），1: GBK</p>
        /// </summary>
        [JsonProperty("EncodingFormat")]
        public ulong? EncodingFormat{ get; set; }

        /// <summary>
        /// <p>使用默认时间状态。true：开启后将使用系统当前时间或 Kafka 消息时间戳作为日志时间戳；false：关闭将使用日志中的时间字段作为日志时间戳。 默认：true</p>
        /// </summary>
        [JsonProperty("DefaultTimeSwitch")]
        public bool? DefaultTimeSwitch{ get; set; }

        /// <summary>
        /// <p>整条日志匹配规则，只有RechargeType为fullregex_log时有效</p>
        /// </summary>
        [JsonProperty("LogRegex")]
        public string LogRegex{ get; set; }

        /// <summary>
        /// <p>解析失败日志是否上传，true表示上传，false表示不上传</p>
        /// </summary>
        [JsonProperty("UnMatchLogSwitch")]
        public bool? UnMatchLogSwitch{ get; set; }

        /// <summary>
        /// <p>解析失败日志的键名称</p>
        /// </summary>
        [JsonProperty("UnMatchLogKey")]
        public string UnMatchLogKey{ get; set; }

        /// <summary>
        /// <p>解析失败日志时间来源，0: 系统当前时间，1: Kafka消息时间戳</p>
        /// </summary>
        [JsonProperty("UnMatchLogTimeSrc")]
        public ulong? UnMatchLogTimeSrc{ get; set; }

        /// <summary>
        /// <p>默认时间来源，0: 系统当前时间，1: Kafka消息时间戳</p>
        /// </summary>
        [JsonProperty("DefaultTimeSrc")]
        public ulong? DefaultTimeSrc{ get; set; }

        /// <summary>
        /// <p>时间字段，日志中代表时间的字段名。</p><ul><li>当DefaultTimeSwitch为false，且RechargeType数据提取模式为 <code>json_log</code> JSON-文件日志 或 <code>fullregex_log</code> 单行完全正则-文件日志时， TimeKey不能为空。</li></ul>
        /// </summary>
        [JsonProperty("TimeKey")]
        public string TimeKey{ get; set; }

        /// <summary>
        /// <p>时间提取正则表达式。</p><ul><li>当DefaultTimeSwitch为false，且RechargeType数据提取模式为 <code>minimalist_log</code> 单行全文-文件日志时， TimeRegex不能为空。</li><li>仅需输入日志中代表时间的字段的正则表达式即可；若匹配到多个字段，将使用第一个。<br> 例：日志原文为：message with time 2022-08-08 14:20:20，则您可以设置提取时间正则为\d\d\d\d-\d\d-\d\d \d\d:\d\d:\d\d</li></ul>
        /// </summary>
        [JsonProperty("TimeRegex")]
        public string TimeRegex{ get; set; }

        /// <summary>
        /// <p>时间字段格式。</p><ul><li>当DefaultTimeSwitch为false时， TimeFormat不能为空。</li></ul>
        /// </summary>
        [JsonProperty("TimeFormat")]
        public string TimeFormat{ get; set; }

        /// <summary>
        /// <p>时间字段时区。</p><ul><li><p>当DefaultTimeSwitch为false时， TimeZone不能为空。</p></li><li><p>时区格式规则<br>前缀：使用 GMT 或 UTC 作为时区基准<br>偏移量：</p><ul><li><code>-</code> 表示西时区（比基准时间晚）</li><li><code>+</code> 表示东时区（比基准时间早）</li><li>格式为 ±HH:MM（小时:分钟）</li></ul></li><li><p>当前支持：<br><pre><code>&quot;GMT-12:00&quot; &quot;GMT-11:00&quot; &quot;GMT-10:00&quot; &quot;GMT-09:30&quot; &quot;GMT-09:00&quot; &quot;GMT-08:00&quot; &quot;GMT-07:00&quot; &quot;GMT-06:00&quot; &quot;GMT-05:00&quot; &quot;GMT-04:00&quot; &quot;GMT-03:30&quot; &quot;GMT-03:00&quot; &quot;GMT-02:00&quot; &quot;GMT-01:00&quot; &quot;GMT+00:00&quot;&quot;GMT+01:00&quot;&quot;GMT+02:00&quot;&quot;GMT+03:30&quot;&quot;GMT+04:00&quot;&quot;GMT+04:30&quot;&quot;GMT+05:00&quot;&quot;GMT+05:30&quot;&quot;GMT+05:45&quot;&quot;GMT+06:00&quot;&quot;GMT+06:30&quot;&quot;GMT+07:00&quot;&quot;GMT+08:00&quot;&quot;GMT+09:00&quot;&quot;GMT+09:30&quot;&quot;GMT+10:00&quot;&quot;GMT+10:30&quot;&quot;GMT+11:00&quot;&quot;GMT+11:30&quot;&quot;GMT+12:00&quot;&quot;GMT+12:45&quot;&quot;GMT+13:00&quot;&quot;GMT+14:00&quot;&quot;UTC-11:00&quot;&quot;UTC-10:00&quot;&quot;UTC-09:00&quot;&quot;UTC-08:00&quot;&quot;UTC-12:00&quot;&quot;UTC-07:00&quot;&quot;UTC-06:00&quot;&quot;UTC-05:00&quot;&quot;UTC-04:30&quot;&quot;UTC-04:00&quot;&quot;UTC-03:30&quot;&quot;UTC-03:00&quot;&quot;UTC-02:00&quot;&quot;UTC-01:00&quot;&quot;UTC+00:00&quot;&quot;UTC+01:00&quot;&quot;UTC+02:00&quot;&quot;UTC+03:00&quot;&quot;UTC+03:30&quot;&quot;UTC+04:00&quot;&quot;UTC+04:30&quot;&quot;UTC+05:00&quot;&quot;UTC+05:45&quot;&quot;UTC+06:00&quot;&quot;UTC+06:30&quot;&quot;UTC+07:00&quot;&quot;UTC+08:00&quot;&quot;UTC+09:00&quot;&quot;UTC+09:30&quot;&quot;UTC+10:00&quot;&quot;UTC+11:00&quot;&quot;UTC+12:00&quot;&quot;UTC+13:00&quot;</code></pre></p></li></ul>
        /// </summary>
        [JsonProperty("TimeZone")]
        public string TimeZone{ get; set; }

        /// <summary>
        /// <p>元数据信息，Kafka导入支持kafka_topic,kafka_partition,kafka_offset,kafka_timestamp</p>
        /// </summary>
        [JsonProperty("Metadata")]
        public string[] Metadata{ get; set; }

        /// <summary>
        /// <p>日志Key列表，RechargeType为full_regex_log、delimiter_log时必填</p>
        /// </summary>
        [JsonProperty("Keys")]
        public string[] Keys{ get; set; }

        /// <summary>
        /// <p>json解析模式，开启首层数据解析</p>
        /// </summary>
        [JsonProperty("ParseArray")]
        public bool? ParseArray{ get; set; }

        /// <summary>
        /// <p>分隔符解析模式-分隔符<br>当解析格式为分隔符提取时，该字段必填</p>
        /// </summary>
        [JsonProperty("Delimiter")]
        public string Delimiter{ get; set; }

        /// <summary>
        /// <p>JSON嵌套展开配置。仅RechargeType为json_log时生效，不传表示不开启。</p>
        /// </summary>
        [JsonProperty("JsonExpand")]
        public JsonExpandInfo JsonExpand{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "RechargeType", this.RechargeType);
            this.SetParamSimple(map, prefix + "EncodingFormat", this.EncodingFormat);
            this.SetParamSimple(map, prefix + "DefaultTimeSwitch", this.DefaultTimeSwitch);
            this.SetParamSimple(map, prefix + "LogRegex", this.LogRegex);
            this.SetParamSimple(map, prefix + "UnMatchLogSwitch", this.UnMatchLogSwitch);
            this.SetParamSimple(map, prefix + "UnMatchLogKey", this.UnMatchLogKey);
            this.SetParamSimple(map, prefix + "UnMatchLogTimeSrc", this.UnMatchLogTimeSrc);
            this.SetParamSimple(map, prefix + "DefaultTimeSrc", this.DefaultTimeSrc);
            this.SetParamSimple(map, prefix + "TimeKey", this.TimeKey);
            this.SetParamSimple(map, prefix + "TimeRegex", this.TimeRegex);
            this.SetParamSimple(map, prefix + "TimeFormat", this.TimeFormat);
            this.SetParamSimple(map, prefix + "TimeZone", this.TimeZone);
            this.SetParamArraySimple(map, prefix + "Metadata.", this.Metadata);
            this.SetParamArraySimple(map, prefix + "Keys.", this.Keys);
            this.SetParamSimple(map, prefix + "ParseArray", this.ParseArray);
            this.SetParamSimple(map, prefix + "Delimiter", this.Delimiter);
            this.SetParamObj(map, prefix + "JsonExpand.", this.JsonExpand);
        }
    }
}

