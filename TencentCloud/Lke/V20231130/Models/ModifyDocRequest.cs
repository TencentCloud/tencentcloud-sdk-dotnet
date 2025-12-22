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

namespace TencentCloud.Lke.V20231130.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class ModifyDocRequest : AbstractModel
    {
        
        /// <summary>
        /// 应用ID，获取方法参看[如何获取   BotBizId](https://cloud.tencent.com/document/product/1759/109469#4eecb8c1-6ce4-45f5-8fa2-b269449d8efa)
        /// </summary>
        [JsonProperty("BotBizId")]
        public string BotBizId{ get; set; }

        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 是否引用链接
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// 标签适用范围，1:全部，2:按条件。默认为1。
        /// </summary>
        [JsonProperty("AttrRange")]
        public ulong? AttrRange{ get; set; }

        /// <summary>
        /// 登录用户主账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginUin")]
        public string LoginUin{ get; set; }

        /// <summary>
        /// 登录用户子账号(集成商模式必填)
        /// </summary>
        [JsonProperty("LoginSubAccountUin")]
        public string LoginSubAccountUin{ get; set; }

        /// <summary>
        /// 关联的标签
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabelRefer[] AttrLabels{ get; set; }

        /// <summary>
        /// 网页(或自定义链接)地址
        /// </summary>
        [JsonProperty("WebUrl")]
        public string WebUrl{ get; set; }

        /// <summary>
        /// 外部引用链接类型 0：系统链接 1：自定义链接
        /// 值为1时，WebUrl 字段不能为空，否则不生效。
        /// </summary>
        [JsonProperty("ReferUrlType")]
        public ulong? ReferUrlType{ get; set; }

        /// <summary>
        /// 有效开始时间，单位为unix时间戳
        /// </summary>
        [JsonProperty("ExpireStart")]
        public string ExpireStart{ get; set; }

        /// <summary>
        /// 有效结束时间，单位为unix时间戳，默认值为0代表永久有效
        /// </summary>
        [JsonProperty("ExpireEnd")]
        public string ExpireEnd{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 是否可下载，IsRefer为true并且ReferUrlType为0时，该值才有意义
        /// </summary>
        [JsonProperty("IsDownload")]
        public bool? IsDownload{ get; set; }

        /// <summary>
        /// 需要修改的内容类型  0  无效 1 更新文档cos信息 2 更新文档引用信息 3 更新文档刷新频率 4 腾讯文档刷新
        /// </summary>
        [JsonProperty("ModifyTypes")]
        public ulong?[] ModifyTypes{ get; set; }

        /// <summary>
        /// 文档更新频率
        /// </summary>
        [JsonProperty("UpdatePeriodInfo")]
        public UpdatePeriodInfo UpdatePeriodInfo{ get; set; }

        /// <summary>
        /// 自定义切分规则
        /// </summary>
        [JsonProperty("SplitRule")]
        public string SplitRule{ get; set; }

        /// <summary>
        /// 文档生效域: 1-停用；2-仅开发域；3-仅发布域；4-全域
        /// </summary>
        [JsonProperty("EnableScope")]
        public long? EnableScope{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        public override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "BotBizId", this.BotBizId);
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamSimple(map, prefix + "LoginUin", this.LoginUin);
            this.SetParamSimple(map, prefix + "LoginSubAccountUin", this.LoginSubAccountUin);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "WebUrl", this.WebUrl);
            this.SetParamSimple(map, prefix + "ReferUrlType", this.ReferUrlType);
            this.SetParamSimple(map, prefix + "ExpireStart", this.ExpireStart);
            this.SetParamSimple(map, prefix + "ExpireEnd", this.ExpireEnd);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsDownload", this.IsDownload);
            this.SetParamArraySimple(map, prefix + "ModifyTypes.", this.ModifyTypes);
            this.SetParamObj(map, prefix + "UpdatePeriodInfo.", this.UpdatePeriodInfo);
            this.SetParamSimple(map, prefix + "SplitRule", this.SplitRule);
            this.SetParamSimple(map, prefix + "EnableScope", this.EnableScope);
        }
    }
}

