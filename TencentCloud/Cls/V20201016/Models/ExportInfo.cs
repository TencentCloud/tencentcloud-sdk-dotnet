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

    public class ExportInfo : AbstractModel
    {
        
        /// <summary>
        /// 日志主题ID
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 日志导出任务ID
        /// </summary>
        [JsonProperty("ExportId")]
        public string ExportId{ get; set; }

        /// <summary>
        /// 日志导出查询语句
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// 日志导出文件名
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 日志文件大小
        /// </summary>
        [JsonProperty("FileSize")]
        public ulong? FileSize{ get; set; }

        /// <summary>
        /// 日志导出时间排序
        /// </summary>
        [JsonProperty("Order")]
        public string Order{ get; set; }

        /// <summary>
        /// 日志导出格式
        /// </summary>
        [JsonProperty("Format")]
        public string Format{ get; set; }

        /// <summary>
        /// 日志导出数量
        /// </summary>
        [JsonProperty("Count")]
        public ulong? Count{ get; set; }

        /// <summary>
        /// 日志下载状态。Processing:导出正在进行中，Completed:导出完成，Failed:导出失败，Expired:日志导出已过期(三天有效期), Queuing 排队中
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// 日志导出起始时间
        /// </summary>
        [JsonProperty("From")]
        public long? From{ get; set; }

        /// <summary>
        /// 日志导出结束时间
        /// </summary>
        [JsonProperty("To")]
        public long? To{ get; set; }

        /// <summary>
        /// 日志导出路径,有效期一个小时，请尽快使用该路径下载。
        /// </summary>
        [JsonProperty("CosPath")]
        public string CosPath{ get; set; }

        /// <summary>
        /// 日志导出创建时间
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 语法规则。 默认值为0。
        /// 0：Lucene语法，1：CQL语法。
        /// </summary>
        [JsonProperty("SyntaxRule")]
        public ulong? SyntaxRule{ get; set; }

        /// <summary>
        /// 导出字段
        /// </summary>
        [JsonProperty("DerivedFields")]
        public string[] DerivedFields{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "ExportId", this.ExportId);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileSize", this.FileSize);
            this.SetParamSimple(map, prefix + "Order", this.Order);
            this.SetParamSimple(map, prefix + "Format", this.Format);
            this.SetParamSimple(map, prefix + "Count", this.Count);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "From", this.From);
            this.SetParamSimple(map, prefix + "To", this.To);
            this.SetParamSimple(map, prefix + "CosPath", this.CosPath);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "SyntaxRule", this.SyntaxRule);
            this.SetParamArraySimple(map, prefix + "DerivedFields.", this.DerivedFields);
        }
    }
}

