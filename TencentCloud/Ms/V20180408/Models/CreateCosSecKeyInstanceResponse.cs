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

namespace TencentCloud.Ms.V20180408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateCosSecKeyInstanceResponse : AbstractModel
    {
        
        /// <summary>
        /// COS密钥对应的AppId
        /// </summary>
        [JsonProperty("CosAppid")]
        public ulong? CosAppid{ get; set; }

        /// <summary>
        /// COS密钥对应的存储桶名
        /// </summary>
        [JsonProperty("CosBucket")]
        public string CosBucket{ get; set; }

        /// <summary>
        /// 存储桶对应的地域
        /// </summary>
        [JsonProperty("CosRegion")]
        public string CosRegion{ get; set; }

        /// <summary>
        /// 密钥过期时间
        /// </summary>
        [JsonProperty("ExpireTime")]
        public ulong? ExpireTime{ get; set; }

        /// <summary>
        /// 密钥ID信息
        /// </summary>
        [JsonProperty("CosId")]
        public string CosId{ get; set; }

        /// <summary>
        /// 密钥KEY信息
        /// </summary>
        [JsonProperty("CosKey")]
        public string CosKey{ get; set; }

        /// <summary>
        /// 密钥TOCKEN信息
        /// </summary>
        [JsonProperty("CosTocken")]
        public string CosTocken{ get; set; }

        /// <summary>
        /// 密钥可访问的文件前缀人。例如：CosPrefix=test/123/666，则该密钥只能操作test/123/666为前缀的文件，例如test/123/666/1.txt
        /// </summary>
        [JsonProperty("CosPrefix")]
        public string CosPrefix{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CosAppid", this.CosAppid);
            this.SetParamSimple(map, prefix + "CosBucket", this.CosBucket);
            this.SetParamSimple(map, prefix + "CosRegion", this.CosRegion);
            this.SetParamSimple(map, prefix + "ExpireTime", this.ExpireTime);
            this.SetParamSimple(map, prefix + "CosId", this.CosId);
            this.SetParamSimple(map, prefix + "CosKey", this.CosKey);
            this.SetParamSimple(map, prefix + "CosTocken", this.CosTocken);
            this.SetParamSimple(map, prefix + "CosPrefix", this.CosPrefix);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

