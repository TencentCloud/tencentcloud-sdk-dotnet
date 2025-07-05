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

namespace TencentCloud.Tag.V20180813.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class AttachResourcesTagRequest : AbstractModel
    {
        
        /// <summary>
        /// 业务类型，示例 cvm 。资源所属业务名称（资源六段式中的第三段）
        /// </summary>
        [JsonProperty("ServiceType")]
        public string ServiceType{ get; set; }

        /// <summary>
        /// 资源ID数组，资源个数最多为50
        /// </summary>
        [JsonProperty("ResourceIds")]
        public string[] ResourceIds{ get; set; }

        /// <summary>
        /// 需要绑定的标签键，取值规范参考：https://cloud.tencent.com/document/product/651/13354
        /// </summary>
        [JsonProperty("TagKey")]
        public string TagKey{ get; set; }

        /// <summary>
        /// 需要绑定的标签值，取值规范参考：https://cloud.tencent.com/document/product/651/13354
        /// </summary>
        [JsonProperty("TagValue")]
        public string TagValue{ get; set; }

        /// <summary>
        /// 资源所在地域，不区分地域的资源则不必填。区分地域的资源则必填，且必填时必须是参数ResourceIds.N资源所对应的地域，且如果ResourceIds.N为批量时，这些资源也必须是同一个地域的。例如示例值：ap-beijing，则参数ResourceIds.N中都应该填写该地域的资源。
        /// </summary>
        [JsonProperty("ResourceRegion")]
        public string ResourceRegion{ get; set; }

        /// <summary>
        /// 资源前缀（资源六段式中最后一段"/"前面的部分，例如“qcs::ckafka:ap-shanghai:uin/123456789:ckafkaId/ckafka-o85jq584” 中资源前缀为ckafkaId），cos存储桶不需要传入该字段，其他云资源必填
        /// </summary>
        [JsonProperty("ResourcePrefix")]
        public string ResourcePrefix{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "ServiceType", this.ServiceType);
            this.SetParamArraySimple(map, prefix + "ResourceIds.", this.ResourceIds);
            this.SetParamSimple(map, prefix + "TagKey", this.TagKey);
            this.SetParamSimple(map, prefix + "TagValue", this.TagValue);
            this.SetParamSimple(map, prefix + "ResourceRegion", this.ResourceRegion);
            this.SetParamSimple(map, prefix + "ResourcePrefix", this.ResourcePrefix);
        }
    }
}

