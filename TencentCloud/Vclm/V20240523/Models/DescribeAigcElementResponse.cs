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

namespace TencentCloud.Vclm.V20240523.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DescribeAigcElementResponse : AbstractModel
    {
        
        /// <summary>
        /// <p>主体名称</p>
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// <p>主体id</p>
        /// </summary>
        [JsonProperty("ElementId")]
        public string ElementId{ get; set; }

        /// <summary>
        /// <p>主体描述</p>
        /// </summary>
        [JsonProperty("Description")]
        public string Description{ get; set; }

        /// <summary>
        /// <p>主体参考方式</p><p>枚举值：</p><ul><li>video_refer： 视频角色主体</li><li>image_refer： 多图主体</li></ul>
        /// </summary>
        [JsonProperty("ReferenceType")]
        public string ReferenceType{ get; set; }

        /// <summary>
        /// <p>任务状态</p><p>枚举值：</p><ul><li>pending： 执行中</li><li>failed： 任务失败</li><li>succeed： 任务成功</li></ul>
        /// </summary>
        [JsonProperty("Status")]
        public string Status{ get; set; }

        /// <summary>
        /// <p>厂商列表</p>
        /// </summary>
        [JsonProperty("Provider")]
        public string[] Provider{ get; set; }

        /// <summary>
        /// <p>主体参考图，可通过多张图片设定主体及其细节</p>
        /// </summary>
        [JsonProperty("ElementImageList")]
        public ElementImageList ElementImageList{ get; set; }

        /// <summary>
        /// <p>主体参考视频，可通过视频设定主体及其细节</p>
        /// </summary>
        [JsonProperty("VideoList")]
        public string[] VideoList{ get; set; }

        /// <summary>
        /// <p>为主体配置标签，一个主体可以配置多个标签</p>
        /// </summary>
        [JsonProperty("TagList")]
        public TagList[] TagList{ get; set; }

        /// <summary>
        /// <p>厂商聚合字段</p>
        /// </summary>
        [JsonProperty("ProviderDetails")]
        public ProviderDetail[] ProviderDetails{ get; set; }

        /// <summary>
        /// <p>创建时间</p>
        /// </summary>
        [JsonProperty("CreatedAt")]
        public string CreatedAt{ get; set; }

        /// <summary>
        /// <p>更新时间</p>
        /// </summary>
        [JsonProperty("UpdatedAt")]
        public string UpdatedAt{ get; set; }

        /// <summary>
        /// <p>音色Id</p>
        /// </summary>
        [JsonProperty("ElementVoiceId")]
        public string ElementVoiceId{ get; set; }

        /// <summary>
        /// 唯一请求 ID，由服务端生成，每次请求都会返回（若请求因其他原因未能抵达服务端，则该次请求不会获得 RequestId）。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "ElementId", this.ElementId);
            this.SetParamSimple(map, prefix + "Description", this.Description);
            this.SetParamSimple(map, prefix + "ReferenceType", this.ReferenceType);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamArraySimple(map, prefix + "Provider.", this.Provider);
            this.SetParamObj(map, prefix + "ElementImageList.", this.ElementImageList);
            this.SetParamArraySimple(map, prefix + "VideoList.", this.VideoList);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamArrayObj(map, prefix + "ProviderDetails.", this.ProviderDetails);
            this.SetParamSimple(map, prefix + "CreatedAt", this.CreatedAt);
            this.SetParamSimple(map, prefix + "UpdatedAt", this.UpdatedAt);
            this.SetParamSimple(map, prefix + "ElementVoiceId", this.ElementVoiceId);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

