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

namespace TencentCloud.Ssm.V20190923.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ListSecretsRequest : AbstractModel
    {
        
        /// <summary>
        /// <p>查询列表的起始位置，以0开始，不设置默认为0。</p>
        /// </summary>
        [JsonProperty("Offset")]
        public ulong? Offset{ get; set; }

        /// <summary>
        /// <p>单次查询返回的最大数量，0或不设置则使用默认值 20。</p>
        /// </summary>
        [JsonProperty("Limit")]
        public ulong? Limit{ get; set; }

        /// <summary>
        /// <p>根据创建时间的排序方式，0或者不设置则使用降序排序， 1 表示升序排序。</p>
        /// </summary>
        [JsonProperty("OrderType")]
        public ulong? OrderType{ get; set; }

        /// <summary>
        /// <p>根据凭据状态进行过滤。<br>默认为0表示查询全部。<br>1 --  表示查询Enabled 凭据列表。<br>2 --  表示查询Disabled 凭据列表。<br>3 --  表示查询PendingDelete 凭据列表。<br>4 --  表示PendingCreate。<br>5 --  表示CreateFailed。<br>其中状态PendingCreate和CreateFailed只有在SecretType为云产品凭据时生效</p>
        /// </summary>
        [JsonProperty("State")]
        public ulong? State{ get; set; }

        /// <summary>
        /// <p>根据凭据名称进行过滤，为空表示不过滤。</p>
        /// </summary>
        [JsonProperty("SearchSecretName")]
        public string SearchSecretName{ get; set; }

        /// <summary>
        /// <p>标签过滤条件。</p>
        /// </summary>
        [JsonProperty("TagFilters")]
        public TagFilter[] TagFilters{ get; set; }

        /// <summary>
        /// <p>0  -- 表示用户自定义凭据，默认为0。<br>1  -- 表示用户云产品凭据。<br>2 -- 表示SSH密钥对凭据。<br>3 -- 表示云API密钥对凭据。</p>
        /// </summary>
        [JsonProperty("SecretType")]
        public ulong? SecretType{ get; set; }

        /// <summary>
        /// <p>此参数仅在SecretType参数值为1时生效，<br>当SecretType值为1时：<br>如果ProductName值为空，则表示查询所有类型的云产品凭据；<br>如果ProductName值为某个指定的云产品值如Mysql时，则表示查询Mysql数据库凭据；<br>如果ProductName值为多个云产品值，如：Mysql,Tdsql-mysql,Tdsql_C_Mysql（多个值以英文逗号,分隔开）则表示查询三种云产品类型的凭据；<br>支持的云产品列表请通过接口：DescribeSupportedProducts进行查询。</p>
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// <p>凭据加密类型</p><p>枚举值：</p><ul><li>0： KMS 密钥加密</li><li>1： 软密钥加密</li></ul><p>默认值：0</p>
        /// </summary>
        [JsonProperty("EncryptType")]
        public ulong? EncryptType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Offset", this.Offset);
            this.SetParamSimple(map, prefix + "Limit", this.Limit);
            this.SetParamSimple(map, prefix + "OrderType", this.OrderType);
            this.SetParamSimple(map, prefix + "State", this.State);
            this.SetParamSimple(map, prefix + "SearchSecretName", this.SearchSecretName);
            this.SetParamArrayObj(map, prefix + "TagFilters.", this.TagFilters);
            this.SetParamSimple(map, prefix + "SecretType", this.SecretType);
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "EncryptType", this.EncryptType);
        }
    }
}

