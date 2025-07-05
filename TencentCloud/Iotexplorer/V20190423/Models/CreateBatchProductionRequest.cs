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

namespace TencentCloud.Iotexplorer.V20190423.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateBatchProductionRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("ProductId")]
        public string ProductId{ get; set; }

        /// <summary>
        /// 烧录方式，0为直接烧录，1为动态注册。
        /// </summary>
        [JsonProperty("BurnMethod")]
        public long? BurnMethod{ get; set; }

        /// <summary>
        /// 生成方式，0为系统生成，1为文件上传。
        /// </summary>
        [JsonProperty("GenerationMethod")]
        public long? GenerationMethod{ get; set; }

        /// <summary>
        /// 文件上传URL，用于文件上传时填写。
        /// </summary>
        [JsonProperty("UploadUrl")]
        public string UploadUrl{ get; set; }

        /// <summary>
        /// 量产数量，用于系统生成时填写。
        /// </summary>
        [JsonProperty("BatchCnt")]
        public long? BatchCnt{ get; set; }

        /// <summary>
        /// 是否生成二维码,0为不生成，1为生成。
        /// </summary>
        [JsonProperty("GenerationQRCode")]
        public long? GenerationQRCode{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "ProductId", this.ProductId);
            this.SetParamSimple(map, prefix + "BurnMethod", this.BurnMethod);
            this.SetParamSimple(map, prefix + "GenerationMethod", this.GenerationMethod);
            this.SetParamSimple(map, prefix + "UploadUrl", this.UploadUrl);
            this.SetParamSimple(map, prefix + "BatchCnt", this.BatchCnt);
            this.SetParamSimple(map, prefix + "GenerationQRCode", this.GenerationQRCode);
        }
    }
}

