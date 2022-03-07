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

namespace TencentCloud.Casb.V20200507.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CopyCryptoColumnPolicyRequest : AbstractModel
    {
        
        /// <summary>
        /// 实例Id
        /// </summary>
        [JsonProperty("CasbId")]
        public string CasbId{ get; set; }

        /// <summary>
        /// 元数据id
        /// </summary>
        [JsonProperty("MetaDataId")]
        public string MetaDataId{ get; set; }

        /// <summary>
        /// 目标实例Id 如果和实例Id相同则为同CasbId下的策略复制
        /// </summary>
        [JsonProperty("DstCasbId")]
        public string DstCasbId{ get; set; }

        /// <summary>
        /// 目标实例Id 如果和[元数据id]相同则为同元数据下的策略复制
        /// </summary>
        [JsonProperty("DstMetaDataId")]
        public string DstMetaDataId{ get; set; }

        /// <summary>
        /// 筛选来源数据库的表
        /// </summary>
        [JsonProperty("SrcTableFilter")]
        public CryptoCopyColumnPolicyTableFilter[] SrcTableFilter{ get; set; }

        /// <summary>
        /// 复制同元数据下的策略，需要填写目标数据库名
        /// </summary>
        [JsonProperty("DstDatabaseName")]
        public string DstDatabaseName{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "CasbId", this.CasbId);
            this.SetParamSimple(map, prefix + "MetaDataId", this.MetaDataId);
            this.SetParamSimple(map, prefix + "DstCasbId", this.DstCasbId);
            this.SetParamSimple(map, prefix + "DstMetaDataId", this.DstMetaDataId);
            this.SetParamArrayObj(map, prefix + "SrcTableFilter.", this.SrcTableFilter);
            this.SetParamSimple(map, prefix + "DstDatabaseName", this.DstDatabaseName);
        }
    }
}

