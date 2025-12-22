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

    public class CreateEsRechargeRequest : AbstractModel
    {
        
        /// <summary>
        /// 日志主题id。
        /// - 通过 [获取日志主题列表](https://cloud.tencent.com/document/product/614/56454) 获取日志主题Id。
        /// - 通过 [创建日志主题](https://cloud.tencent.com/document/product/614/56456) 获取日志主题Id。
        /// </summary>
        [JsonProperty("TopicId")]
        public string TopicId{ get; set; }

        /// <summary>
        /// 名称：长度不超过64字符。
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 索引信息。不同索引可以通过英文逗号分隔，支持*通配符
        /// </summary>
        [JsonProperty("Index")]
        public string Index{ get; set; }

        /// <summary>
        /// es查询语句。
        /// </summary>
        [JsonProperty("Query")]
        public string Query{ get; set; }

        /// <summary>
        /// es集群配置信息。
        /// </summary>
        [JsonProperty("EsInfo")]
        public EsInfo EsInfo{ get; set; }

        /// <summary>
        /// es导入信息。
        /// </summary>
        [JsonProperty("ImportInfo")]
        public EsImportInfo ImportInfo{ get; set; }

        /// <summary>
        /// es导入时间字段信息。
        /// </summary>
        [JsonProperty("TimeInfo")]
        public EsTimeInfo TimeInfo{ get; set; }

        /// <summary>
        /// 是否开启投递服务日志。1：关闭，2：开启。默认开启。
        /// </summary>
        [JsonProperty("HasServicesLog")]
        public ulong? HasServicesLog{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "TopicId", this.TopicId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Index", this.Index);
            this.SetParamSimple(map, prefix + "Query", this.Query);
            this.SetParamObj(map, prefix + "EsInfo.", this.EsInfo);
            this.SetParamObj(map, prefix + "ImportInfo.", this.ImportInfo);
            this.SetParamObj(map, prefix + "TimeInfo.", this.TimeInfo);
            this.SetParamSimple(map, prefix + "HasServicesLog", this.HasServicesLog);
        }
    }
}

