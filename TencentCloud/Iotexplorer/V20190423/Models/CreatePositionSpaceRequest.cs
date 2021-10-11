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

    public class CreatePositionSpaceRequest : AbstractModel
    {
        
        /// <summary>
        /// 项目ID
        /// </summary>
        [JsonProperty("ProjectId")]
        public string ProjectId{ get; set; }

        /// <summary>
        /// 空间名称
        /// </summary>
        [JsonProperty("SpaceName")]
        public string SpaceName{ get; set; }

        /// <summary>
        /// 授权类型，0：只读 1：读写
        /// </summary>
        [JsonProperty("AuthorizeType")]
        public long? AuthorizeType{ get; set; }

        /// <summary>
        /// 产品列表
        /// </summary>
        [JsonProperty("ProductIdList")]
        public string[] ProductIdList{ get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// 缩略图
        /// </summary>
        [JsonProperty("Icon")]
        public string Icon{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ProjectId", this.ProjectId);
            this.SetParamSimple(map, prefix + "SpaceName", this.SpaceName);
            this.SetParamSimple(map, prefix + "AuthorizeType", this.AuthorizeType);
            this.SetParamArraySimple(map, prefix + "ProductIdList.", this.ProductIdList);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "Icon", this.Icon);
        }
    }
}

