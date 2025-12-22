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

namespace TencentCloud.Cdwdoris.V20211228.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeBackUpSchedulesRequest : AbstractModel
    {
        
        /// <summary>
        /// 任务类型
        /// 0-不限制，或使用TypeFilters过滤；
        /// 1-备份恢复（包括周期备份和一次性备份）；
        /// 2-数据迁移（包括跨集群迁移和cos迁移）
        /// </summary>
        [JsonProperty("ApplicationType")]
        public long? ApplicationType{ get; set; }

        /// <summary>
        /// 0-未加密；1-已加密
        /// </summary>
        [JsonProperty("EncryptionFilters")]
        public long?[] EncryptionFilters{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ApplicationType", this.ApplicationType);
            this.SetParamArraySimple(map, prefix + "EncryptionFilters.", this.EncryptionFilters);
        }
    }
}

