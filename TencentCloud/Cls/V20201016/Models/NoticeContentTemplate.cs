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

namespace TencentCloud.Cls.V20201016.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class NoticeContentTemplate : AbstractModel
    {
        
        /// <summary>
        /// 通知内容模板ID。
        /// </summary>
        [JsonProperty("NoticeContentId")]
        public string NoticeContentId{ get; set; }

        /// <summary>
        /// 通知内容模板名称
        /// </summary>
        [JsonProperty("Name")]
        public string Name{ get; set; }

        /// <summary>
        /// 语言类型。
        /// 
        /// 0： 中文
        /// 1： 英文
        /// </summary>
        [JsonProperty("Type")]
        public ulong? Type{ get; set; }

        /// <summary>
        /// 通知内容模板信息。
        /// </summary>
        [JsonProperty("NoticeContents")]
        public NoticeContent[] NoticeContents{ get; set; }

        /// <summary>
        /// 通知内容模板标记。
        /// 
        /// 0： 用户自定义
        /// 1： 系统内置
        /// </summary>
        [JsonProperty("Flag")]
        public ulong? Flag{ get; set; }

        /// <summary>
        /// 创建者主账号。
        /// </summary>
        [JsonProperty("Uin")]
        public ulong? Uin{ get; set; }

        /// <summary>
        /// 创建/修改者子账号。
        /// </summary>
        [JsonProperty("SubUin")]
        public ulong? SubUin{ get; set; }

        /// <summary>
        /// 创建时间 秒级(s)时间戳。
        /// </summary>
        [JsonProperty("CreateTime")]
        public long? CreateTime{ get; set; }

        /// <summary>
        /// 更新时间 秒级(s)时间戳。
        /// </summary>
        [JsonProperty("UpdateTime")]
        public long? UpdateTime{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "NoticeContentId", this.NoticeContentId);
            this.SetParamSimple(map, prefix + "Name", this.Name);
            this.SetParamSimple(map, prefix + "Type", this.Type);
            this.SetParamArrayObj(map, prefix + "NoticeContents.", this.NoticeContents);
            this.SetParamSimple(map, prefix + "Flag", this.Flag);
            this.SetParamSimple(map, prefix + "Uin", this.Uin);
            this.SetParamSimple(map, prefix + "SubUin", this.SubUin);
            this.SetParamSimple(map, prefix + "CreateTime", this.CreateTime);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
        }
    }
}

