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

    public class DescribeDocResponse : AbstractModel
    {
        
        /// <summary>
        /// 文档ID
        /// </summary>
        [JsonProperty("DocBizId")]
        public string DocBizId{ get; set; }

        /// <summary>
        /// 文件名称
        /// </summary>
        [JsonProperty("FileName")]
        public string FileName{ get; set; }

        /// <summary>
        /// 文件类型
        /// </summary>
        [JsonProperty("FileType")]
        public string FileType{ get; set; }

        /// <summary>
        /// cos路径
        /// </summary>
        [JsonProperty("CosUrl")]
        public string CosUrl{ get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        [JsonProperty("UpdateTime")]
        public string UpdateTime{ get; set; }

        /// <summary>
        /// 文档状态： 1-未生成 2-生成中 3-生成成功 4-生成失败 5-删除中 6-删除成功 7-审核中 8-审核失败 9-审核成功 10-待发布 11-发布中 12-已发布 13-学习中 14-学习失败 15-更新中 16-更新失败 17-解析中 18-解析失败 19-导入失败 20-已过期 21-超量失效 22-超量失效恢复
        /// </summary>
        [JsonProperty("Status")]
        public long? Status{ get; set; }

        /// <summary>
        /// 文档状态描述
        /// </summary>
        [JsonProperty("StatusDesc")]
        public string StatusDesc{ get; set; }

        /// <summary>
        /// 生成失败原因
        /// </summary>
        [JsonProperty("Reason")]
        public string Reason{ get; set; }

        /// <summary>
        /// 答案中是否引用
        /// </summary>
        [JsonProperty("IsRefer")]
        public bool? IsRefer{ get; set; }

        /// <summary>
        /// 问答对数量
        /// </summary>
        [JsonProperty("QaNum")]
        public long? QaNum{ get; set; }

        /// <summary>
        /// 是否删除
        /// </summary>
        [JsonProperty("IsDeleted")]
        public bool? IsDeleted{ get; set; }

        /// <summary>
        /// 文档来源
        /// </summary>
        [JsonProperty("Source")]
        public long? Source{ get; set; }

        /// <summary>
        /// 文档来源描述
        /// </summary>
        [JsonProperty("SourceDesc")]
        public string SourceDesc{ get; set; }

        /// <summary>
        /// 是否允许重新生成
        /// </summary>
        [JsonProperty("IsAllowRestart")]
        public bool? IsAllowRestart{ get; set; }

        /// <summary>
        /// qa是否已删除
        /// </summary>
        [JsonProperty("IsDeletedQa")]
        public bool? IsDeletedQa{ get; set; }

        /// <summary>
        /// 问答是否生成中
        /// </summary>
        [JsonProperty("IsCreatingQa")]
        public bool? IsCreatingQa{ get; set; }

        /// <summary>
        /// 是否允许删除
        /// </summary>
        [JsonProperty("IsAllowDelete")]
        public bool? IsAllowDelete{ get; set; }

        /// <summary>
        /// 是否允许操作引用开关
        /// </summary>
        [JsonProperty("IsAllowRefer")]
        public bool? IsAllowRefer{ get; set; }

        /// <summary>
        /// 是否生成过问答
        /// </summary>
        [JsonProperty("IsCreatedQa")]
        public bool? IsCreatedQa{ get; set; }

        /// <summary>
        /// 文档字符量
        /// </summary>
        [JsonProperty("DocCharSize")]
        public string DocCharSize{ get; set; }

        /// <summary>
        /// 是否允许编辑
        /// </summary>
        [JsonProperty("IsAllowEdit")]
        public bool? IsAllowEdit{ get; set; }

        /// <summary>
        /// 标签适用范围 1：全部，2：按条件范围
        /// </summary>
        [JsonProperty("AttrRange")]
        public long? AttrRange{ get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        [JsonProperty("AttrLabels")]
        public AttrLabel[] AttrLabels{ get; set; }

        /// <summary>
        /// 分类ID
        /// </summary>
        [JsonProperty("CateBizId")]
        public string CateBizId{ get; set; }

        /// <summary>
        /// 文档是否停用，false:未停用，true:已停用
        /// </summary>
        [JsonProperty("IsDisabled")]
        public bool? IsDisabled{ get; set; }

        /// <summary>
        /// 是否支持下载
        /// 注意：此字段可能返回 null，表示取不到有效值。
        /// </summary>
        [JsonProperty("IsDownload")]
        public bool? IsDownload{ get; set; }

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
            this.SetParamSimple(map, prefix + "DocBizId", this.DocBizId);
            this.SetParamSimple(map, prefix + "FileName", this.FileName);
            this.SetParamSimple(map, prefix + "FileType", this.FileType);
            this.SetParamSimple(map, prefix + "CosUrl", this.CosUrl);
            this.SetParamSimple(map, prefix + "UpdateTime", this.UpdateTime);
            this.SetParamSimple(map, prefix + "Status", this.Status);
            this.SetParamSimple(map, prefix + "StatusDesc", this.StatusDesc);
            this.SetParamSimple(map, prefix + "Reason", this.Reason);
            this.SetParamSimple(map, prefix + "IsRefer", this.IsRefer);
            this.SetParamSimple(map, prefix + "QaNum", this.QaNum);
            this.SetParamSimple(map, prefix + "IsDeleted", this.IsDeleted);
            this.SetParamSimple(map, prefix + "Source", this.Source);
            this.SetParamSimple(map, prefix + "SourceDesc", this.SourceDesc);
            this.SetParamSimple(map, prefix + "IsAllowRestart", this.IsAllowRestart);
            this.SetParamSimple(map, prefix + "IsDeletedQa", this.IsDeletedQa);
            this.SetParamSimple(map, prefix + "IsCreatingQa", this.IsCreatingQa);
            this.SetParamSimple(map, prefix + "IsAllowDelete", this.IsAllowDelete);
            this.SetParamSimple(map, prefix + "IsAllowRefer", this.IsAllowRefer);
            this.SetParamSimple(map, prefix + "IsCreatedQa", this.IsCreatedQa);
            this.SetParamSimple(map, prefix + "DocCharSize", this.DocCharSize);
            this.SetParamSimple(map, prefix + "IsAllowEdit", this.IsAllowEdit);
            this.SetParamSimple(map, prefix + "AttrRange", this.AttrRange);
            this.SetParamArrayObj(map, prefix + "AttrLabels.", this.AttrLabels);
            this.SetParamSimple(map, prefix + "CateBizId", this.CateBizId);
            this.SetParamSimple(map, prefix + "IsDisabled", this.IsDisabled);
            this.SetParamSimple(map, prefix + "IsDownload", this.IsDownload);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

