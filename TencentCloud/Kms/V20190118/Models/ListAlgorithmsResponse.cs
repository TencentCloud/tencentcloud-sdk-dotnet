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

namespace TencentCloud.Kms.V20190118.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListAlgorithmsResponse : AbstractModel
    {
        
        /// <summary>
        /// 本地区支持的对称加密算法
        /// </summary>
        [JsonProperty("SymmetricAlgorithms")]
        public AlgorithmInfo[] SymmetricAlgorithms{ get; set; }

        /// <summary>
        /// 本地区支持的非对称加密算法
        /// </summary>
        [JsonProperty("AsymmetricAlgorithms")]
        public AlgorithmInfo[] AsymmetricAlgorithms{ get; set; }

        /// <summary>
        /// 本地区支持的非对称签名验签算法
        /// </summary>
        [JsonProperty("AsymmetricSignVerifyAlgorithms")]
        public AlgorithmInfo[] AsymmetricSignVerifyAlgorithms{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArrayObj(map, prefix + "SymmetricAlgorithms.", this.SymmetricAlgorithms);
            this.SetParamArrayObj(map, prefix + "AsymmetricAlgorithms.", this.AsymmetricAlgorithms);
            this.SetParamArrayObj(map, prefix + "AsymmetricSignVerifyAlgorithms.", this.AsymmetricSignVerifyAlgorithms);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

