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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateStudioProductRequest : AbstractModel
    {
        
        /// <summary>
        /// 产品名称，名称不能和已经存在的产品名称重复。命名规则：[a-zA-Z0-9:_-]{1,32}
        /// </summary>
        [JsonProperty("ProductName")]
        public string ProductName{ get; set; }

        /// <summary>
        /// 产品分组模板ID , ( 自定义模板填写1 , 控制台调用会使用预置的其他ID)
        /// </summary>
        [JsonProperty("CategoryId")]
        public long? CategoryId{ get; set; }

        /// <summary>
        /// 产品类型 填写 ( 0 普通产品 )
        /// </summary>
        [JsonProperty("ProductType")]
        public long? ProductType{ get; set; }

        /// <summary>
        /// 加密类型 加密类型，1表示证书认证，2表示签名认证。
        /// </summary>
        [JsonProperty("EncryptionType")]
        public string EncryptionType{ get; set; }

        /// <summary>
        /// 连接类型 可以填写 wifi cellular else
        /// </summary>
        [JsonProperty("NetType")]
        public string NetType{ get; set; }

        /// <summary>
        /// 数据协议 (1 使用物模型)
        /// </summary>
        [JsonProperty("DataProtocol")]
        public long? DataProtocol{ get; set; }

        /// <summary>
        /// 产品描述
        /// </summary>
        [JsonProperty("ProductDesc")]
        public string ProductDesc{ get; set; }

        /// <summary>
        /// 产品的项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProductName", this.ProductName);
            this.SetParamSimple(map, prefix + "CategoryId", this.CategoryId);
            this.SetParamSimple(map, prefix + "ProductType", this.ProductType);
            this.SetParamSimple(map, prefix + "EncryptionType", this.EncryptionType);
            this.SetParamSimple(map, prefix + "NetType", this.NetType);
            this.SetParamSimple(map, prefix + "DataProtocol", this.DataProtocol);
            this.SetParamSimple(map, prefix + "ProductDesc", this.ProductDesc);
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
        }
    }
}

