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

namespace TencentCloud.Faceid.V20180301.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class Encryption : AbstractModel
    {
        
        /// <summary>
        /// 有加密需求的用户，接入传入kms的CiphertextBlob，关于数据加密可查阅<a href="https://cloud.tencent.com/document/product/1007/47180">数据加密</a> 文档。
        /// </summary>
        [JsonProperty("CiphertextBlob")]
        public string CiphertextBlob{ get; set; }

        /// <summary>
        /// 在使用加密服务时，填入要被加密的字段。本接口中可填入加密后的一个或多个字段
        /// </summary>
        [JsonProperty("EncryptList")]
        public string[] EncryptList{ get; set; }

        /// <summary>
        /// 有加密需求的用户，传入CBC加密的初始向量（客户自定义字符串，长度16字符）。
        /// </summary>
        [JsonProperty("Iv")]
        public string Iv{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CiphertextBlob", this.CiphertextBlob);
            this.SetParamArraySimple(map, prefix + "EncryptList.", this.EncryptList);
            this.SetParamSimple(map, prefix + "Iv", this.Iv);
        }
    }
}

