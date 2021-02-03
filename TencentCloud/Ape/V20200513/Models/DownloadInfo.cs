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

namespace TencentCloud.Ape.V20200513.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DownloadInfo : AbstractModel
    {
        
        /// <summary>
        /// 图片基础信息
        /// </summary>
        [JsonProperty("ImageInfo")]
        public ImageInfo ImageInfo{ get; set; }

        /// <summary>
        /// 图片原图URL
        /// </summary>
        [JsonProperty("ImageUrl")]
        public string ImageUrl{ get; set; }

        /// <summary>
        /// 图片缩略图URL
        /// </summary>
        [JsonProperty("ImageThumbUrl")]
        public string ImageThumbUrl{ get; set; }

        /// <summary>
        /// 订单Id
        /// </summary>
        [JsonProperty("OrderId")]
        public string OrderId{ get; set; }

        /// <summary>
        /// 订单创建时间
        /// </summary>
        [JsonProperty("OrderCreateTime")]
        public string OrderCreateTime{ get; set; }

        /// <summary>
        /// 下载Id
        /// </summary>
        [JsonProperty("DownloadId")]
        public string DownloadId{ get; set; }

        /// <summary>
        /// 下载时间
        /// </summary>
        [JsonProperty("DownloadTime")]
        public string DownloadTime{ get; set; }

        /// <summary>
        /// 图片购买类型，单张/会员
        /// </summary>
        [JsonProperty("ConsumeType")]
        public long? ConsumeType{ get; set; }

        /// <summary>
        /// 是否首次下载
        /// </summary>
        [JsonProperty("FirstDownload")]
        public bool? FirstDownload{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamObj(map, prefix + "ImageInfo.", this.ImageInfo);
            this.SetParamSimple(map, prefix + "ImageUrl", this.ImageUrl);
            this.SetParamSimple(map, prefix + "ImageThumbUrl", this.ImageThumbUrl);
            this.SetParamSimple(map, prefix + "OrderId", this.OrderId);
            this.SetParamSimple(map, prefix + "OrderCreateTime", this.OrderCreateTime);
            this.SetParamSimple(map, prefix + "DownloadId", this.DownloadId);
            this.SetParamSimple(map, prefix + "DownloadTime", this.DownloadTime);
            this.SetParamSimple(map, prefix + "ConsumeType", this.ConsumeType);
            this.SetParamSimple(map, prefix + "FirstDownload", this.FirstDownload);
        }
    }
}

