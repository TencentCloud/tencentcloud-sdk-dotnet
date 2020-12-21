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

namespace TencentCloud.Ims.V20200713.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ImsDetail : AbstractModel
    {
        
        /// <summary>
        /// 文本内容
        /// </summary>
        [JsonProperty("Content")]
        public string Content{ get; set; }

        /// <summary>
        /// 数据方式， 0：我审，1：人审
        /// </summary>
        [JsonProperty("DataSource")]
        public long? DataSource{ get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// ----非必选，该参数暂未对外开放
        /// </summary>
        [JsonProperty("EvilType")]
        public long? EvilType{ get; set; }

        /// <summary>
        /// 机器审核时间
        /// </summary>
        [JsonProperty("ModerationTime")]
        public string ModerationTime{ get; set; }

        /// <summary>
        /// 最后更新人
        /// </summary>
        [JsonProperty("UpdateUser")]
        public string UpdateUser{ get; set; }

        /// <summary>
        /// 内容RequestId
        /// </summary>
        [JsonProperty("ContentId")]
        public string ContentId{ get; set; }

        /// <summary>
        /// 自主审核结果
        /// </summary>
        [JsonProperty("OperEvilType")]
        public long? OperEvilType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Content", this.Content);
            this.SetParamSimple(map, prefix + "DataSource", this.DataSource);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "EvilType", this.EvilType);
            this.SetParamSimple(map, prefix + "ModerationTime", this.ModerationTime);
            this.SetParamSimple(map, prefix + "UpdateUser", this.UpdateUser);
            this.SetParamSimple(map, prefix + "ContentId", this.ContentId);
            this.SetParamSimple(map, prefix + "OperEvilType", this.OperEvilType);
        }
    }
}

