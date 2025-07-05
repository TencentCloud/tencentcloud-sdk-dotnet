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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class CreateChannelCodeRequest : AbstractModel
    {
        
        /// <summary>
        /// 欢迎语类型:0普通欢迎语,1渠道欢迎语
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

        /// <summary>
        /// 使用成员用户id集
        /// </summary>
        [JsonProperty("UseUserId")]
        public long?[] UseUserId{ get; set; }

        /// <summary>
        /// 使用成员企微账号id集
        /// </summary>
        [JsonProperty("UseUserOpenId")]
        public string[] UseUserOpenId{ get; set; }

        /// <summary>
        /// 应用ID,字典表中的APP_TYPE值,多个已逗号分隔
        /// </summary>
        [JsonProperty("AppIds")]
        public string AppIds{ get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonProperty("Source")]
        public string Source{ get; set; }

        /// <summary>
        /// 渠道来源名称
        /// </summary>
        [JsonProperty("SourceName")]
        public string SourceName{ get; set; }

        /// <summary>
        /// 二维码名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("Tag")]
        public WeComTagDetail[] Tag{ get; set; }

        /// <summary>
        /// 自动通过好友：0开启 1关闭, 默认开启
        /// </summary>
        [JsonProperty("SkipVerify")]
        public long? SkipVerify{ get; set; }

        /// <summary>
        /// 欢迎语id（通过欢迎语新增返回的id）
        /// </summary>
        [JsonProperty("MsgId")]
        public long? MsgId{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 渠道类型 0 未知 1 公域 2私域
        /// </summary>
        [JsonProperty("SourceType")]
        public long? SourceType{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArraySimple(map, prefix + "UseUserId.", this.UseUserId);
            this.SetParamArraySimple(map, prefix + "UseUserOpenId.", this.UseUserOpenId);
            this.SetParamSimple(map, prefix + "AppIds", this.AppIds);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArrayObj(map, prefix + "Tag.", this.Tag);
            this.SetParamSimple(map, prefix + "SkipVerify", this.SkipVerify);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "SourceType", this.SourceType);
        }
    }
}

