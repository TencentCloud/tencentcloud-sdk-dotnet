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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class UnTagResourcesRequest : AbstractModel
    {
        
        /// <summary>
        /// 资源六段式列表。腾讯云使用资源六段式描述一个资源。可参考[访问管理](https://cloud.tencent.com/document/product/598/67350)-概览-接口列表-资源六段式信息
        /// 例如：ResourceList.1 = qcs::${ServiceType}:${Region}:uin/${Account}:${ResourcePrefix}/${ResourceId}。
        /// N取值范围：0~9
        /// </summary>
        [JsonProperty("ResourceList")]
        public string[] ResourceList{ get; set; }

        /// <summary>
        /// 标签键。
        /// 取值范围：0~9
        /// </summary>
        [JsonProperty("TagKeys")]
        public string[] TagKeys{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamArraySimple(map, prefix + "ResourceList.", this.ResourceList);
            this.SetParamArraySimple(map, prefix + "TagKeys.", this.TagKeys);
        }
    }
}

