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

namespace TencentCloud.Domain.V20180808.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CheckBatchStatusRequest : AbstractModel
    {
        
        /// <summary>
        /// 操作日志 ID数组，最多 200 个
        /// 可通过任意批量操作接口获取，例如：
        /// [BatchModifyDomainInfo](https://cloud.tencent.com/document/product/242/49197)
        /// [ModifyDomainDNSBatch](https://cloud.tencent.com/document/product/242/49211)
        /// [ModifyDomainOwnerBatch](https://cloud.tencent.com/document/product/242/49196)
        /// [UpdateProhibitionBatch](https://cloud.tencent.com/document/api/242/49193)
        /// [TransferProhibitionBatch](https://cloud.tencent.com/document/api/242/49194)
        /// [TransferInDomainBatch](https://cloud.tencent.com/document/api/242/49195)
        /// </summary>
        [JsonProperty("LogIds")]
        public ulong?[] LogIds{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "LogIds.", this.LogIds);
        }
    }
}

