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

namespace TencentCloud.Wav.V20210129.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ChannelCodeInnerDetail : AbstractModel
    {
        
        /// <summary>
        /// 渠道活码id
        /// </summary>
        [JsonProperty("Id")]
        public long? Id{ get; set; }

        /// <summary>
        /// 欢迎语类型，0：普通欢迎语、1:渠道欢迎语
        /// </summary>
        [JsonProperty("Type")]
        public long? Type{ get; set; }

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
        /// 使用成员用户id集
        /// </summary>
        [JsonProperty("UseUserIdList")]
        public long?[] UseUserIdList{ get; set; }

        /// <summary>
        /// 使用成员企微账号id集
        /// </summary>
        [JsonProperty("UseUserOpenIdList")]
        public string[] UseUserOpenIdList{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("TagList")]
        public WeComTagDetail[] TagList{ get; set; }

        /// <summary>
        /// 自动通过好友，0：开启、1：关闭，默认0开启
        /// </summary>
        [JsonProperty("SkipVerify")]
        public long? SkipVerify{ get; set; }

        /// <summary>
        /// 添加好友人数
        /// </summary>
        [JsonProperty("Friends")]
        public long? Friends{ get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("Remark")]
        public string Remark{ get; set; }

        /// <summary>
        /// 欢迎语id（通过欢迎语新增返回的id）
        /// </summary>
        [JsonProperty("MsgId")]
        public long? MsgId{ get; set; }

        /// <summary>
        /// 联系我config_id
        /// </summary>
        [JsonProperty("ConfigId")]
        public string ConfigId{ get; set; }

        /// <summary>
        /// 联系我二维码地址
        /// </summary>
        [JsonProperty("QrCodeUrl")]
        public string QrCodeUrl{ get; set; }

        /// <summary>
        /// 记录状态， 0：有效、1：无效
        /// </summary>
        [JsonProperty("RecStatus")]
        public long? RecStatus{ get; set; }

        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("AppId")]
        public string AppId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Id", this.Id);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceName", this.SourceName);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamArraySimple(map, prefix + "UseUserIdList.", this.UseUserIdList);
            this.SetParamArraySimple(map, prefix + "UseUserOpenIdList.", this.UseUserOpenIdList);
            this.SetParamArrayObj(map, prefix + "TagList.", this.TagList);
            this.SetParamSimple(map, prefix + "SkipVerify", this.SkipVerify);
            this.SetParamSimple(map, prefix + "Friends", this.Friends);
            this.SetParamSimple(map, prefix + "Remark", this.Remark);
            this.SetParamSimple(map, prefix + "MsgId", this.MsgId);
            this.SetParamSimple(map, prefix + "ConfigId", this.ConfigId);
            this.SetParamSimple(map, prefix + "QrCodeUrl", this.QrCodeUrl);
            this.SetParamSimple(map, prefix + "RecStatus", this.RecStatus);
            this.SetParamSimple(map, prefix + "AppId", this.AppId);
        }
    }
}

