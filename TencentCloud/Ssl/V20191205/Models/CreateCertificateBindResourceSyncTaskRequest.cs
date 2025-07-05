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

namespace TencentCloud.Ssl.V20191205.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCertificateBindResourceSyncTaskRequest : AbstractModel
    {
        
        /// <summary>
        /// 证书ID列表，总数不能超过100
        /// </summary>
        [JsonProperty("CertificateIds")]
        public string[] CertificateIds{ get; set; }

        /// <summary>
        /// 是否使用缓存， 1使用缓存，0不使用缓存； 默认为1使用缓存； 若当前证书ID存在半小时已完成的任务， 则使用缓存的情况下， 会读取半小时内离当前时间最近的查询结果
        /// </summary>
        [JsonProperty("IsCache")]
        public ulong? IsCache{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "CertificateIds.", this.CertificateIds);
            this.SetParamSimple(map, prefix + "IsCache", this.IsCache);
        }
    }
}

