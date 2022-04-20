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

namespace TencentCloud.Dbbrain.V20210527.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SQLFilter : AbstractModel
    {
        
        /// <summary>
        /// 任务ID。
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 任务状态，取值包括RUNNING - 运行中, FINISHED - 已完成, TERMINATED - 已终止。
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// SQL类型，取值包括SELECT, UPDATE, DELETE, INSERT, REPLACE。
        /// </summary>
        [JsonProperty("SqlType")]
        public string SqlType{ get; set; }

        /// <summary>
        /// 筛选SQL的关键词，多个关键词用英文逗号拼接。
        /// </summary>
        [JsonProperty("OriginKeys")]
        public string OriginKeys{ get; set; }

        /// <summary>
        /// 筛选SQL的规则。
        /// </summary>
        [JsonProperty("OriginRule")]
        public string OriginRule{ get; set; }

        /// <summary>
        /// 已拒绝SQL数目。
        /// </summary>
        [JsonProperty("RejectedSqlCount")]
        public long? RejectedSqlCount{ get; set; }

        /// <summary>
        /// 当前并发数。
        /// </summary>
        [JsonProperty("CurrentConcurrency")]
        public long? CurrentConcurrency{ get; set; }

        /// <summary>
        /// 最大并发数。
        /// </summary>
        [JsonProperty("MaxConcurrency")]
        public long? MaxConcurrency{ get; set; }

        /// <summary>
        /// 任务创建时间。
        /// </summary>
        [JsonProperty("CreateTime")]
        public string CreateTime{ get; set; }

        /// <summary>
        /// 当前时间。
        /// </summary>
        [JsonProperty("CurrentTime")]
        public string CurrentTime{ get; set; }

        /// <summary>
        /// 限流过期时间。
        /// </summary>
        [JsonProperty("ExpireTime")]
        public string ExpireTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "SqlType", this.SqlType);
            this.SetParamSimple(map, prefix + "OriginKeys", this.OriginKeys);
            this.SetParamSimple(map, prefix + "OriginRule", this.OriginRule);
            this.SetParamSimple(map, prefix + "RejectedSqlCount", this.RejectedSqlCount);
            this.SetParamSimple(map, prefix + "CurrentConcurrency", this.CurrentConcurrency);
            this.SetParamSimple(map, prefix + "MaxConcurrency", this.MaxConcurrency);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "CurrentTime", this.CurrentTime);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
        }
    }
}

