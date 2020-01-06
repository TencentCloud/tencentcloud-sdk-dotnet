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

namespace TencentCloud.Bmlb.V20180625.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ReplaceCertRequest : AbstractModel
    {
        
        /// <summary>
        /// 要被替换的证书ID
        /// </summary>
        [JsonProperty("OldCertId")]
        public string OldCertId{ get; set; }

        /// <summary>
        /// 证书内容
        /// </summary>
        [JsonProperty("NewCert")]
        public string NewCert{ get; set; }

        /// <summary>
        /// 证书名称
        /// </summary>
        [JsonProperty("NewAlias")]
        public string NewAlias{ get; set; }

        /// <summary>
        /// 私钥内容，证书类型为SVR时不需要传递
        /// </summary>
        [JsonProperty("NewKey")]
        public string NewKey{ get; set; }

        /// <summary>
        /// 是否删除旧证书，0 表示不删除，1 表示删除
        /// </summary>
        [JsonProperty("DeleteOld")]
        public ulong? DeleteOld{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "OldCertId", this.OldCertId);
            this.SetParamSimple(map, prefix + "NewCert", this.NewCert);
            this.SetParamSimple(map, prefix + "NewAlias", this.NewAlias);
            this.SetParamSimple(map, prefix + "NewKey", this.NewKey);
            this.SetParamSimple(map, prefix + "DeleteOld", this.DeleteOld);
        }
    }
}

